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
        AccountViewModel MapToViewModel(Account account);
    }

    partial class AccountMapper : IRegister
    {
        public void Register(TypeAdapterConfig config)
        {
            config.NewConfig<(CreateAccountModel Model, Guid ExternalUserId), Account>()
                .Map(d => d.ExternalUserId, src => src.ExternalUserId)
                .Map(d => d.PathToProfilePicture, src => src.Model.PathToProfilePicture)
                .Map(d => d.Type, src => AccountTypeEnum.Error)
                .Map(d => d.IsDeleted, src => false)
                .Map(d => d.CreatedAt, src => DateTimeOffset.UtcNow);

            config.NewConfig<Account, AccountViewModel>()
                .Map(d => d.Id, src => src.Id)
                .Map(d => d.ExternalUserId, src => src.ExternalUserId)
                .Map(d => d.Type, src => src.Type)
                .Map(d => d.PathToProfilePicture, src => src.PathToProfilePicture)
                .Map(d => d.Description, src => src.Description)
                .Map(d => d.CreatedAt, src => src.CreatedAt)
                .Map(d => d.UpdatedAt, src => src.UpdatedAt);
        }
    }
}
