using Domain.Abstractions;
using Domain.Enums;
using System.Collections;

namespace Domain.Entities
{
    public class Account : BaseEntity<Guid>, IHaveDateTrack, IHaveDeleteTrack, IEnumerable<Guid>
    {
        /// <summary>
        /// Идентификатор пользователя внешней системы идентификации
        /// </summary>
        public required Guid ExternalUserId { get; set; }

        /// <summary>
        /// Тип аккаунта
        /// </summary>
        public required AccountTypeEnum Type { get; set; }

        /// <summary>
        /// Связка с бизнес-информацией (для бизнес-пользователей)
        /// </summary>
        public BusinessInformation? BusinessInformation { get; set; }

        /// <summary>
        /// Связка с организациями (для бизнес-пользователей)
        /// </summary>
        public ICollection<Organization>? Organizations { get; set; }

        /// <summary>
        /// Путь до изображения профиля
        /// </summary>
        public string? PathToProfilePicture { get; set; }
        
        /// <summary>
        /// Описание профиля
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
        public required bool IsDeleted { get; set; }

        public IEnumerator<Guid> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
