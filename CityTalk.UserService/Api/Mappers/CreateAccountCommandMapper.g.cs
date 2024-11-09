using System;
using Abstractions.Models;
using Api.Services.User;
using Application.Accounts.Dtos;
using Application.Users.Commands;
using CommonLibrary.Protos;

namespace Api.Services.User
{
    public partial class CreateAccountCommandMapper : ICreateAccountCommandMapper
    {
        public CreateAccountCommand MapToCommand(RegisterAccountRequest p1)
        {
            return p1 == null ? null : new CreateAccountCommand() {Body = new CreateAccountModel()
            {
                IsBusiness = p1.IsBusiness,
                Description = p1.Description,
                PathToProfilePicture = p1.PathToProfilePicture
            }};
        }
        public CreatedOrUpdatedResponse MapToResponse(CreatedOrUpdatedEntityViewModel<Guid> p2)
        {
            return p2 == null ? null : new CreatedOrUpdatedResponse() {Id = p2.Id.ToString()};
        }
    }
}