using Domain.Abstractions;

namespace Domain.Entities
{
    public class Organization : BaseEntity<Guid>, IHaveDateTrack, IHaveDeleteTrack
    {
        /// <summary>
        /// Идентификатор владельца
        /// </summary>
        public required Guid OwnerId { get; set; }
        public Account? Owner { get; set; }

        /// <summary>
        /// Название организации
        /// </summary>
        public required string Name { get; set; }
        
        /// <summary>
        /// Описание
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// Дата создания
        /// </summary>
        public required DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// Дата изменения
        /// </summary>
        public DateTimeOffset? UpdatedAt { get; set; }

        /// <summary>
        /// Статус удаления
        /// </summary>
        public bool IsDeleted { get; set; }
    }
}
