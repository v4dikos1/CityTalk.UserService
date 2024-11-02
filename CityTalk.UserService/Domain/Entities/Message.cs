namespace Domain.Entities
{
    public class Message : BaseEntity<Guid>
    {
        /// <summary>
        /// Идентификатор чата
        /// </summary>
        public required Guid ChatId { get; set; }

        /// <summary>
        /// Идентификатор пользователя, отправившего сообщение (связка с типом пользователя)
        /// </summary>
        public required Guid UserTypeBindId { get; set; }
        public UserTypeBind UserTypeBind { get; set; } = null!;

        /// <summary>
        /// Идентификатор пересылаемого сообщения
        /// </summary>
        public Guid? RootMessageId { get; set; }
        public Message? RootMessage { get; set; }

        /// <summary>
        /// Текст
        /// </summary>
        public required string Content { get; set; } = string.Empty;

        /// <summary>
        /// Вложения
        /// </summary>
        public string? Attachment { get; set; }

        /// <summary>
        /// Прочитано
        /// </summary>
        public bool IsReaded { get; set; }
    }
}
