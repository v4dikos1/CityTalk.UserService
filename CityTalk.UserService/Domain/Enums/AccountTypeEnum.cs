using System.ComponentModel;

namespace Domain.Enums
{
    /// <summary>
    /// Тип аккаунта
    /// </summary>
    public enum AccountTypeEnum
    {
        /// <summary>
        /// Ошибка при создании
        /// </summary>
        [Description("Ошибка")]
        Error = 0,

        /// <summary>
        /// Обычный пользователь
        /// </summary>
        [Description("Обычный пользователь")]
        Default = 1,

        /// <summary>
        /// Бизнес-пользователь
        /// </summary>
        [Description("Бизнес-пользователь")]
        Business = 2
    }
}
