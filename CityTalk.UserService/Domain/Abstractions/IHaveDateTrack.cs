namespace Domain.Abstractions
{
    public interface IHaveDateTrack
    {
        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// Дата обновления
        /// </summary>
        public DateTimeOffset? UpdatedAt { get; set; }
    }
}
