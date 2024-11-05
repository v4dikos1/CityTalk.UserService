using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.EntityConfigurations
{
    internal class BusinessInformationConfiguration : IEntityTypeConfiguration<BusinessInformation>
    {
        public void Configure(EntityTypeBuilder<BusinessInformation> builder)
        {
            builder.ToTable("business_information");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired(true);

            builder.HasIndex(x => x.AccountId).IsUnique(true);
            builder.Property(x => x.AccountId).IsRequired(true);
            builder.HasOne(x => x.Account)
                .WithOne(x => x.BusinessInformation)
                .HasForeignKey<BusinessInformation>(x => x.AccountId);

            builder.Property(x => x.TIN).IsRequired(true);
            builder.HasIndex(x => x.TIN).IsUnique(true);
        }
    }
}
