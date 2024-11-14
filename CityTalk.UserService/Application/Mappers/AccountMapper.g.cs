using System;
using Application.Accounts;
using Application.Accounts.Dtos;
using Domain.Entities;
using Domain.Enums;

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
        public AccountListViewModel MapToListViewModel(Account p3)
        {
            return p3 == null ? null : new AccountListViewModel()
            {
                Id = p3.Id,
                ExternalUserId = p3.ExternalUserId,
                Type = p3.Type,
                PathToProfilePicture = p3.PathToProfilePicture,
                Description = p3.Description,
                CreatedAt = p3.CreatedAt,
                UpdatedAt = p3.UpdatedAt == null ? default(DateTimeOffset) : (DateTimeOffset)p3.UpdatedAt
            };
        }
    }
}