using Abstractions.Services;
using Application.Accounts.Dtos;
using Application.Accounts.Queries;
using Core.Exceptions;
using Domain;
using Mapster;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Accounts.Handlers
{
    internal class AccountsQueriesHandlers(ApplicationDbContext dbContext, IAccountMapper accountMapper, IAccountService accountService)
        : IRequestHandler<GetAccountQuery, AccountViewModel>, IRequestHandler<GetAccountsListQuery, AccountListViewModel>
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

        public async Task<AccountListViewModel> Handle(GetAccountsListQuery request, CancellationToken cancellationToken)
        {
            var accountsQuery = dbContext.Accounts
                .OrderBy(x => x.CreatedAt);

            var accountsList = await accountsQuery
                .Take(request.Limit)
                .Skip(request.Offset)
                .ProjectToType<AccountViewModel>()
                .ToListAsync(cancellationToken);

            return new AccountListViewModel { Accounts = accountsList };
        }
    }
}
