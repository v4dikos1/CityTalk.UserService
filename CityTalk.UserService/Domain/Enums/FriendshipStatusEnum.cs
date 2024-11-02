using System.ComponentModel;

namespace Domain.Enums
{
    public enum FriendshipStatusEnum
    {
        /// <summary>
        /// Заявка ожидает подтверждения
        /// </summary>
        [Description("Ожидает подтверждения")]
        Waiting = 0,

        /// <summary>
        /// Заявка принята
        /// </summary>
        [Description("Подтверждено")]
        Accepted = 1
    }
}
