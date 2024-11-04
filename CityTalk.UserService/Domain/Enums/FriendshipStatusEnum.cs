using System.ComponentModel;

namespace Domain.Enums
{
    public enum FriendshipStatusEnum
    {
        /// <summary>
        /// Заявка ожидает подтверждения
        /// </summary>
        [Description("Заявка отправлена")]
        Sended = 0,

        /// <summary>
        /// Друг
        /// </summary>
        [Description("Друг")]
        Friend = 1,

        /// <summary>
        /// Подписчик
        /// </summary>
        [Description("Подписчик")]
        Subscriber = 2
    }
}
