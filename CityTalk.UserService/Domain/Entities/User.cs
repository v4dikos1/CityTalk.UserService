namespace Domain.Entities
{
    public class User : BaseEntity<Guid>
    {

        /// <summary>
        /// Имя пользователя
        /// </summary>
        public required string Username { get; set; } = string.Empty;

        /// <summary>
        /// Электронная почта
        /// </summary>
        public required string Email { get; set; } = string.Empty;
    }
}
