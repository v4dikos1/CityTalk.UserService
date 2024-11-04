namespace Domain.Entities
{
    public class ChatUserBind : BaseEntity<Guid>
    {
        /// <summary>
        /// Идентификатор чата
        /// </summary>
        public required Guid ChatId { get; set; }
        public Chat? Chat { get; set; }

        /// <summary>
        /// Идентификатор пользователя
        /// </summary>
        public required Guid MemberId { get; set; }
        public Account? Member { get; set; }

        /// <summary>
        /// Дата вступления в чат
        /// </summary>
        public required DateTimeOffset JoinedAt { get; set; }
    }
}
