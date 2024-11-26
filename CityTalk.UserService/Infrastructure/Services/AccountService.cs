using Abstractions.Services;
using CommonLibrary.Exceptions;
using Domain;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Services
{
    public class AccountService(ApplicationDbContext dbContext) : IAccountService
    {
        public async Task<Account> GetAccountAsync(string id, CancellationToken cancellationToken)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id), "Идентификатор аккаунта не задан.");
            }

            var account = await dbContext.Accounts
                .Where(x => x.ExternalUserId == Guid.Parse(id))
                .SingleOrDefaultAsync(cancellationToken);

            if (account == null)
            {
                throw new ObjectNotFoundException(
                    $"Аккаунт с внешним идентификатором \"{id}\" не найден.");
            }

            return account;
        }
    }
}
