using System.ComponentModel;

namespace Domain.Enums
{
    public enum AttachmentTypeEnum
    {
        /// <summary>
        /// Другие файлы
        /// </summary>
        [Description("Документ")]
        Document = 0,

        /// <summary>
        /// Изображение
        /// </summary>
        [Description("Изображение")]
        Photo = 1,

        /// <summary>
        /// Видеозапись
        /// </summary>
        [Description("Видеозапись")]
        Video = 2,

        /// <summary>
        /// Gif-анимация
        /// </summary>
        [Description("GIF-анимация")]
        Gif = 3,

        /// <summary>
        /// Аудиозапись
        /// </summary>
        [Description("Аудиозапись")]
        Audio = 4,

        /// <summary>
        /// Голосовая запись
        /// </summary>
        [Description("Голосовое сообщение")]
        Voice = 5,

        /// <summary>
        /// Видеозапись "Кружок"
        /// </summary>
        [Description("Видеосообщение")]
        VideoVoice = 6,

        /// <summary>
        /// Стикер
        /// </summary>
        [Description("Стикер")]
        Sticker = 7,
    }
}
