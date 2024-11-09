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
                Description = p1.Item1.Description,
                CreatedAt = DateTimeOffset.UtcNow,
                IsDeleted = false
            };
        }
    }
}