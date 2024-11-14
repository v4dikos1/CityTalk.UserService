using Domain.Enums;

namespace Application.Accounts.Dtos
{
    public class AccountViewModel
    {
        public required Guid Id { get; set; }
        public required Guid ExternalUserId { get; set; }
        public required AccountTypeEnum Type { get; set; }
        public string? PathToProfilePicture { get; set; }
        public string? Description { get; set; }
        public required DateTimeOffset CreatedAt { get; set; }
        public required DateTimeOffset UpdatedAt { get; set; }

    }
}
