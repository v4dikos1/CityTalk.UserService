using Abstractions.Models;
using Application.Users.Commands;
using CommonLibrary.Protos;
using Mapster;

namespace Api.Services.User
{
    [Mapper]
    public interface ICreateAccountCommandMapper
    {
        CreateAccountCommand MapToCommand(RegisterAccountRequest request);
        CreatedOrUpdatedResponse MapToResponse(CreatedOrUpdatedEntityViewModel<Guid> createdOrUpdatedEntityViewModel);
    }
    partial class CreateAccountCommandMapper : IRegister
    {
        public void Register(TypeAdapterConfig config)
        {
            config.NewConfig<RegisterAccountRequest, CreateAccountCommand>()
                .Map(d => d.Body.IsBusiness, src => src.IsBusiness)
                .Map(d => d.Body.Description, src => src.Description)
                .Map(d => d.Body.PathToProfilePicture, src => src.PathToProfilePicture);

            config.NewConfig<CreatedOrUpdatedEntityViewModel<Guid>, CreatedOrUpdatedResponse>()
                .Map(d => d.Id, src => src.Id);
        }
    }
}
