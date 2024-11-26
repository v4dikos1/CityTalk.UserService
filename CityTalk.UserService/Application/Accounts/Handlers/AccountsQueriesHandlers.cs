using Abstractions.Services;
using Application.Accounts.Dtos;
using Application.Accounts.Queries;
using CommonLibrary.Exceptions;
using CommonLibrary.Protos;
using Domain;
using Mapster;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Accounts.Handlers
{
    internal class AccountsQueriesHandlers(ApplicationDbContext dbContext, IAccountMapper accountMapper, IAccountService accountService)
        : IRequestHandler<GetAccountQuery, AccountResponse>, IRequestHandler<GetAccountsListQuery, AccountsListRsponse>
    {
        public async Task<AccountResponse> Handle(GetAccountQuery request, CancellationToken cancellationToken)
        {
            var account = await accountService.GetAccountAsync(request.ExternalUserId, cancellationToken);

            if (account == null)
            {
                throw new ObjectNotFoundException(
                    $"Аккаунт с внешним идентификатором \"{request.ExternalUserId}\" не найден.");
            }

            return accountMapper.MapToAccountResponse(account);
        }

        public async Task<AccountsListRsponse> Handle(GetAccountsListQuery request, CancellationToken cancellationToken)
        {
            var accountsQuery = dbContext.Accounts
                .OrderBy(x => x.CreatedAt);

            var accountsList = await accountsQuery
                .Take(request.Limit)
                .Skip(request.Offset)
                .ToListAsync(cancellationToken);

            return accountMapper.MapToAccountsListResponse(accountsList);
        }
    }
}
