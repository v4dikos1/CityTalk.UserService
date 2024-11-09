using Application.Accounts.Dtos;
using Domain.Entities;
using Domain.Enums;
using Mapster;

namespace Application.Accounts
{
    [Mapper]
    public interface IAccountMapper
    {
        Account MapToEntity((CreateAccountModel model, Guid externalUserId) src);
    }

    partial class AccountMapper : IRegister
    {
        public void Register(TypeAdapterConfig config)
        {
            config.NewConfig<(CreateAccountModel Model, Guid ExternalUserId), Account>()
                .Map(d => d.ExternalUserId, src => src.ExternalUserId)
                .Map(d => d.Description, src => src.Model.Description)
                .Map(d => d.PathToProfilePicture, src => src.Model.PathToProfilePicture)
                .Map(d => d.Type, src => AccountTypeEnum.Error)
                .Map(d => d.IsDeleted, src => false)
                .Map(d => d.CreatedAt, src => DateTimeOffset.UtcNow);
        }
    }
}
