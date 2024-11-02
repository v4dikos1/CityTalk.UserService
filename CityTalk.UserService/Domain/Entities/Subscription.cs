namespace Domain.Entities
{
    public class Subscription
    {
        /// <summary>
        /// Идентификатор пользователя
        /// </summary>
        public required Guid UserId { get; set; }
        public User User { get; set; } = null!;

        /// <summary>
        /// Идентификатор бизнес-пользователя
        /// </summary>
        public required Guid BusinessUserId { get; set; }
        public BusinessUser BusinessUser { get; set; } = null!;

        /// <summary>
        /// Дата подписки
        /// </summary>
        public DateTimeOffset CreatedAt { get; set; }
    }
}
