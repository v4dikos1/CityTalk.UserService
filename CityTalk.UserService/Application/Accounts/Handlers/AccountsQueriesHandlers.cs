using Abstractions.Services;
using Application.Accounts.Dtos;
using Application.Accounts.Queries;
using Core.Exceptions;
using Domain;
using MediatR;

namespace Application.Accounts.Handlers
{
    internal class AccountsQueriesHandlers(ApplicationDbContext dbContext, IAccountMapper accountMapper, IAccountService accountService)
        : IRequestHandler<GetAccountQuery, AccountViewModel>
    {
        public async Task<AccountViewModel> Handle(GetAccountQuery request, CancellationToken cancellationToken)
        {
            var account = await accountService.GetAccountAsync(request.ExternalUserId, cancellationToken);

            if (account == null)
            {
                throw new ObjectNotFoundException(
                    $"Аккаунт с внешним идентификатором \"{request.ExternalUserId}\" не найден.");
            }

            return accountMapper.MapToViewModel(account);
        }
    }
}
