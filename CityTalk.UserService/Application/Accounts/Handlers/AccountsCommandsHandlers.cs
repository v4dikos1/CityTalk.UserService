using Abstractions.Models;
using Application.Users.Commands;
using Domain;
using Domain.Entities;
using Domain.Enums;
using MediatR;

namespace Application.Accounts.Handlers
{
    internal class AccountsCommandsHandlers(ApplicationDbContext dbContext, IAccountMapper accountMapper) :
        IRequestHandler<CreateAccountCommand, CreatedOrUpdatedEntityViewModel<Guid>>
    {
        public async Task<CreatedOrUpdatedEntityViewModel<Guid>> Handle(CreateAccountCommand request, CancellationToken cancellationToken)
        {
            var accountType = AccountTypeEnum.Error;

            if (request.Body.IsBusiness)
            {
                accountType = AccountTypeEnum.Business;
            }
            else
            {
                accountType = AccountTypeEnum.Default;
            }

            var accountToCreate = accountMapper.MapToEntity((request.Body, Guid.NewGuid()));

            var createdAccount = await dbContext.AddAsync(accountToCreate, cancellationToken);
            await dbContext.SaveChangesAsync();

            return new CreatedOrUpdatedEntityViewModel<Guid>(createdAccount.Entity.Id);
        }
    }
}
