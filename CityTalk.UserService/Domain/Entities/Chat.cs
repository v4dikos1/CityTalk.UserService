using Domain.Abstractions;
using Domain.Enums;

namespace Domain.Entities
{
    public class Chat : BaseEntity<Guid>, IHaveDateTrack, IHaveDeleteTrack
    {
        /// <summary>
        /// Тип чата
        /// </summary>
        public required ChatTypeEnum Type { get; set; }

        /// <summary>
        /// Путь до изображения чата
        /// </summary>
        public string? PathToPicture { get; set; }

        /// <summary>
        /// Название чата
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Описание чата
        /// </summary>
        public string? Description { get; set; } = string.Empty;

        /// <summary>
        /// Связка с участниками
        /// </summary>
        public ICollection<ChatUserBind>? MemberBinds { get; set; }

        public required DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset? UpdatedAt { get; set; }
        public required bool IsDeleted { get; set; }
    }
}
