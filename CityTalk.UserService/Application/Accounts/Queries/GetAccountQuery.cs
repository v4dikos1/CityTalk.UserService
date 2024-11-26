using CommonLibrary.Protos;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Application.Accounts.Queries
{
    public class GetAccountQuery : IRequest<AccountResponse>
    {
        [FromRoute]
        public required string ExternalUserId { get; set; }
    }
}
