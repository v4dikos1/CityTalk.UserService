using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.EntityConfigurations
{
    public class BusinessUserConfiguration : IEntityTypeConfiguration<BusinessUser>
    {
        public void Configure(EntityTypeBuilder<BusinessUser> builder)
        {
            builder.ToTable("business_user");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired();

            builder.Property(x => x.TIN).IsRequired();
            builder.Property(x => x.Email).IsRequired();
            builder.Property(x => x.OrganizationName).IsRequired();

            builder.Property(x => x.CreatedAt).IsRequired();
            builder.Property(x => x.IsDeleted).IsRequired();
            builder.Property(x => x.UpdatedAt);
        }
    }
}
