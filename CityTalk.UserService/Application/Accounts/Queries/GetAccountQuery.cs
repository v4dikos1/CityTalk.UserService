using Application.Accounts.Dtos;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Application.Accounts.Queries
{
    public class GetAccountQuery : IRequest<AccountViewModel>
    {
        [FromRoute]
        public required string ExternalUserId { get; set; }
    }
}
