namespace Domain.Entities
{
    public abstract class BaseEntity<T> where T: notnull
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public required T Id { get; set; }
    }
}
