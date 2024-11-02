using System.ComponentModel;

namespace Domain.Enums
{
    /// <summary>
    /// Тип аккаунта
    /// </summary>
    public enum AccountTypeEnum
    {
        /// <summary>
        /// Обычный пользователь
        /// </summary>
        [Description("Обычный пользователь")]
        Default = 0,

        /// <summary>
        /// Бизнес-пользователь
        /// </summary>
        [Description("Бизнес-пользователь")]
        Business = 1
    }
}
