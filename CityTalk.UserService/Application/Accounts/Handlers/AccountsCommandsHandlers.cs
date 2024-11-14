using Abstractions.Models;
using Abstractions.Services;
using Application.Users.Commands;
using Core.Exceptions;
using Domain;
using Domain.Entities;
using Domain.Enums;
using MediatR;

namespace Application.Accounts.Handlers
{
    internal class AccountsCommandsHandlers(ApplicationDbContext dbContext, IAccountMapper accountMapper, IAccountService accountService) :
        IRequestHandler<CreateAccountCommand, CreatedOrUpdatedEntityViewModel<Guid>>
    {
        public async Task<CreatedOrUpdatedEntityViewModel<Guid>> Handle(CreateAccountCommand request, CancellationToken cancellationToken)
        {
            var accountType = AccountTypeEnum.Error;

            //Идентификатор пользователя из внешней системы (кейклок). В дальнейшем будет заменен реальным значением.
            var externalUserId = Guid.NewGuid();

            var accountWithSameId = await accountService.GetAccountAsync(externalUserId.ToString(), cancellationToken);
            if (accountWithSameId != null)
            {
                throw new ObjectAlreadyExistsException(
                    $"Аккаунт с внешним идентификатором \"{externalUserId}\" уже существует.");
            }

            if (request.Body.IsBusiness)
            {
                accountType = AccountTypeEnum.Business;
            }
            else
            {
                accountType = AccountTypeEnum.Default;
            }

            var accountToCreate = accountMapper.MapToEntity((request.Body, Guid.NewGuid()));
            accountToCreate.Type = accountType;

            var createdAccount = await dbContext.AddAsync(accountToCreate, cancellationToken);
            await dbContext.SaveChangesAsync();

            return new CreatedOrUpdatedEntityViewModel<Guid>(createdAccount.Entity.Id);
        }
    }
}
