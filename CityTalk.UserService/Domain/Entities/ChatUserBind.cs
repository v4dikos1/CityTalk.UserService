namespace Domain.Entities
{
    public class ChatUserBind
    {
        /// <summary>
        /// Идентификатор чата
        /// </summary>
        public required Guid ChatId { get; set; }
        public Chat Chat { get; set; } = null!;

        /// <summary>
        /// Идентификатор пользователя (связка с типом пользователя)
        /// </summary>
        public required Guid UserTypeBindId { get; set; }
        public UserTypeBind UserTypeBind { get; set; } = null!;

        /// <summary>
        /// Дата вступления в чат
        /// </summary>
        public required DateTimeOffset JoinedAt { get; set; }
    }
}
