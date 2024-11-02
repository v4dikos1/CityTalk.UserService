namespace Domain.Entities
{
    public class BaseEntity<T>
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public T Id { get; set; } = default!;

        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// Дата обновления
        /// </summary>
        public DateTimeOffset? UpdatedAt { get; set;}

        /// <summary>
        /// Удалена ли сущность?
        /// </summary>
        public bool IsDeleted { get; set; }
    }
}
