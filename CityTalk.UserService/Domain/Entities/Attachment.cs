using Domain.Enums;

namespace Domain.Entities
{
    public class Attachment : BaseEntity<Guid>
    {
        /// <summary>
        /// Путь до файла
        /// </summary>
        public required string Path { get; set; }

        /// <summary>
        /// Тип вложения
        /// </summary>
        public required AttachmentTypeEnum Type { get; set; }
    }
}
