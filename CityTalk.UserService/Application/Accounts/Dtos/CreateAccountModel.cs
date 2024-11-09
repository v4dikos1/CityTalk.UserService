namespace Application.Accounts.Dtos
{
    public class CreateAccountModel
    {
        /// <summary>
        /// Является ли бизнес-аккаунтом
        /// </summary>
        public required bool IsBusiness { get; set; }

        /// <summary>
        /// Описание
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// Аватарка
        /// </summary>
        public string? PathToProfilePicture { get; set; }
    }
}
