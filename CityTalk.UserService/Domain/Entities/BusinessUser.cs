namespace Domain.Entities
{
    public class BusinessUser : BaseEntity<Guid>
    {
        /// <summary>
        /// ИНН
        /// </summary>
        public required string TIN { get; set; }

        /// <summary>
        /// Электронная почта
        /// </summary>
        public required string Email { get; set; }

        /// <summary>
        /// Наименование организации
        /// </summary>
        public required string OrganizationName { get; set; }
    }
}
