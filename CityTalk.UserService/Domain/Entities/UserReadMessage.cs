namespace Domain.Entities
{
    public class UserReadMessage : BaseEntity<Guid>
    {
        /// <summary>
        /// Идентификатор пользователя, прочитавшего сообщение
        /// </summary>
        public required Guid UserId { get; set; }
        public Account? User { get; set; }

        /// <summary>
        /// Идентификатор прочитанного сообщения
        /// </summary>
        public required Guid MessageId { get; set; }
        public Message? Message { get; set; }

        /// <summary>
        /// Время, когда сообщение было прочитано
        /// </summary>
        public required DateTimeOffset ReadAt { get; set; }
    }
}
