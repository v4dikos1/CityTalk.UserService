namespace Domain.Entities
{
    public class BusinessInformation : BaseEntity<Guid>
    {
        /// <summary>
        /// Идентификатор бизнес-аккаунта
        /// </summary>
        public required Guid AccountId { get; set; }
        public Account? Account { get; set; }

        /// <summary>
        /// ИНН
        /// </summary>
        public required string TIN { get; set; }
    }
}
