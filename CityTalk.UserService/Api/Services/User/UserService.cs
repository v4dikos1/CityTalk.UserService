using Application.Accounts.Dtos;
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
            var command = new CreateAccountCommand
            { 
                Body = new CreateAccountModel 
                {
                    IsBusiness = request.IsBusiness,
                    Description = request.Description,
                    PathToProfilePicture = request.PathToProfilePicture
                }
            };

            var result = await mediator.Send(command);

            var response = new CreatedOrUpdatedResponse { Id = result.Id.ToString() };

            return response;
        }
    }
}
