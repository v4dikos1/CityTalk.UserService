using Application.Accounts.Dtos;
using MediatR;

namespace Application.Accounts.Queries
{
    public class GetAccountsListQuery : IRequest<AccountListViewModel>
    {
        public required int Limit { get; set; }
        public int Offset { get; set; }
    }
}
