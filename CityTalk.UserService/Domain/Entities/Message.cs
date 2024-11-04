using Domain.Abstractions;

namespace Domain.Entities
{
    public class Message : BaseEntity<Guid>, IHaveDateTrack, IHaveDeleteTrack
    {
        /// <summary>
        /// Идентификатор чата
        /// </summary>
        public required Guid ChatId { get; set; }
        public Chat? Chat { get; set; }

        /// <summary>
        /// Идентификатор пользователя, отправившего сообщение
        /// </summary>
        public required Guid SenderId { get; set; }
        public Account? Sender { get; set; }

        /// <summary>
        /// Идентификатор пересылаемого сообщения
        /// </summary>
        public Guid? RootMessageId { get; set; }
        public Message? RootMessage { get; set; }

        /// <summary>
        /// Текст
        /// </summary>
        public required string Content { get; set; }

        /// <summary>
        /// Вложения
        /// </summary>
        public ICollection<Attachment>? Attachments { get; set; }

        /// <summary>
        /// Пользователи, прочитавшие сообщение
        /// </summary>
        public ICollection<UserReadMessage>? WhoRead { get; set; }

        public required DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset? UpdatedAt { get; set; }
        public required bool IsDeleted { get; set; }
    }
}
