using System;
using System.Collections.Generic;
using Application.Accounts;
using Application.Accounts.Dtos;
using CommonLibrary.Protos;
using Domain.Entities;
using Domain.Enums;
using Mapster;
using Mapster.Utils;

namespace Application.Accounts
{
    public partial class AccountMapper : IAccountMapper
    {
        public Account MapToEntity(ValueTuple<CreateAccountModel, Guid> p1)
        {
            return new Account()
            {
                ExternalUserId = p1.Item2,
                Type = AccountTypeEnum.Error,
                PathToProfilePicture = p1.Item1.PathToProfilePicture,
                CreatedAt = DateTimeOffset.UtcNow,
                IsDeleted = false
            };
        }
        public AccountViewModel MapToViewModel(Account p2)
        {
            return p2 == null ? null : new AccountViewModel()
            {
                Id = p2.Id,
                ExternalUserId = p2.ExternalUserId,
                Type = p2.Type,
                PathToProfilePicture = p2.PathToProfilePicture,
                Description = p2.Description,
                CreatedAt = p2.CreatedAt,
                UpdatedAt = p2.UpdatedAt == null ? default(DateTimeOffset) : (DateTimeOffset)p2.UpdatedAt
            };
        }
        public AccountResponse MapToAccountResponse(Account p3)
        {
            return p3 == null ? null : new AccountResponse()
            {
                Id = p3.Id.ToString(),
                ExternalUserId = p3.ExternalUserId.ToString(),
                Type = Enum<AccountTypeEnum>.ToString(p3.Type),
                PathToProfilePicture = p3.PathToProfilePicture,
                Description = p3.Description,
                CreatedAt = p3.CreatedAt.ToString(),
                UpdatedAt = p3.UpdatedAt == null ? null : ((DateTimeOffset)p3.UpdatedAt).ToString()
            };
        }
        public AccountsListRsponse MapToAccountsListResponse(IEnumerable<Account> p4)
        {
            return p4 == null ? null : new AccountsListRsponse() {Accounts = {p4.Adapt<IEnumerable<AccountResponse>>()}};
        }
    }
}