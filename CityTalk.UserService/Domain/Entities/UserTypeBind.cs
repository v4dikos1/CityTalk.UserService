using Domain.Enums;

namespace Domain.Entities
{
    public class UserTypeBind
    {
        /// <summary>
        /// Идентификатор пользователя
        /// </summary>
        public required Guid UserId { get; set; }
        public User User { get; set; } = null!;

        /// <summary>
        /// Тип аккаунта пользователя
        /// </summary>
        public required AccountTypeEnum Type { get; set; }
    }
}
