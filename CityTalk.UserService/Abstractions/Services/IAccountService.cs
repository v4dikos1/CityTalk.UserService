using Domain.Entities;

namespace Abstractions.Services
{
    public interface IAccountService
    {
        Task<Account> GetAccountAsync(string id, CancellationToken cancellationToken);
    }
}
