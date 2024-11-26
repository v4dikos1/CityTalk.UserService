using CommonLibrary.Protos;
using MediatR;

namespace Application.Accounts.Queries
{
    public class GetAccountsListQuery : IRequest<AccountsListRsponse>
    {
        public required int Limit { get; set; }
        public int Offset { get; set; }
    }
}
