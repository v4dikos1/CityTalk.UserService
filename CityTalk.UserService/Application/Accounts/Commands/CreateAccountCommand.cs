using Abstractions.Models;
using Application.Accounts.Dtos;
using MediatR;

namespace Application.Users.Commands
{
    public class CreateAccountCommand : IRequest<CreatedOrUpdatedEntityViewModel<Guid>>
    {
        /// <summary>
        /// Тело запроса
        /// </summary>
        public required CreateAccountModel Body { get; set; }
    }
}
