namespace Domain.Entities
{
    public class Chat : BaseEntity<Guid>
    {
        /// <summary>
        /// Название чата
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Описание чата
        /// </summary>
        public string? Description { get; set; } = string.Empty;

    }
}
