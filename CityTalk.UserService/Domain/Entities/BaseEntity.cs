namespace Domain.Entities
{
    public abstract class BaseEntity<T> where T: notnull
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public T Id { get; set; } = default!;
    }
}
