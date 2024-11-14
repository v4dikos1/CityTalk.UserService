using Application.Accounts.Dtos;
using Application.Accounts.Queries;
using Application.Users.Commands;
using CommonLibrary.Protos;
using Grpc.Core;
using MediatR;

namespace Api.Services.User
{
    public class UserService(IMediator mediator) : CommonLibrary.Protos.User.UserBase
    {
        public override Task<UserProfile> GetUserProfile(GetUserProfileRequest request, ServerCallContext serverCallContext)
        {
            return Task.FromResult(new UserProfile { Username = "Test" });
        }

        public override async Task<CreatedOrUpdatedResponse> RegisterAccount(RegisterAccountRequest request, ServerCallContext serverCallContext)
        {
            var body = new CreateAccountModel
            {
                IsBusiness = request.IsBusiness,
                Email = request.Email,
                Username = request.Username,
                Password = request.Password,
            };

            if (request.PathToProfilePicture != null)
            {
                body.PathToProfilePicture = request.PathToProfilePicture;
            }

            var command = new CreateAccountCommand
            { 
                Body = body,
            };

            var result = await mediator.Send(command);

            var response = new CreatedOrUpdatedResponse { Id = result.Id.ToString() };

            return response;
        }

        public override async Task<AccountResponse> GetAccount(GetAccountRequest request, ServerCallContext context)
        {
            var query = new GetAccountQuery { ExternalUserId = request.ExternalUserId };

            var result = await mediator.Send(query);

            var response = new AccountResponse
            {
                Id = result.Id.ToString(),
                ExternalUserId = result.ExternalUserId.ToString(),
                Type = result.Type.ToString(),
                PathToProfilePicture = result.PathToProfilePicture,
                Descritpion = result.Description,
                CreatedAt = result.CreatedAt.ToString(),
                UpdatedAt = result.UpdatedAt.ToString()
            };

            return response;
        }
    }
}
