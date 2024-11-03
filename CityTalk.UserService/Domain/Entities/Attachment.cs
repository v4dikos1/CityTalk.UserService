namespace Domain.Entities
{
    public class Attachment : BaseEntity<Guid>
    {
        /// <summary>
        /// Путь до файла
        /// </summary>
        public required string Path { get; set; }
    }
}
