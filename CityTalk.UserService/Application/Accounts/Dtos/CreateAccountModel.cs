namespace Application.Accounts.Dtos
{
    public class CreateAccountModel
    {
        /// <summary>
        /// Является ли бизнес-аккаунтом
        /// </summary>
        public required bool IsBusiness { get; set; }

        /// <summary>
        /// Имя пользователя
        /// </summary>
        public required string Username { get; set; }

        /// <summary>
        /// Электронная почта
        /// </summary>
        public required string Email { get; set; }

        /// <summary>
        /// Пароль
        /// </summary>
        public required string Password { get; set; }

        /// <summary>
        /// Аватарка
        /// </summary>
        public string? PathToProfilePicture { get; set; }
    }
}
