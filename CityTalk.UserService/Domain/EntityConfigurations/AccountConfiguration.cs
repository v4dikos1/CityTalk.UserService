using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.EntityConfigurations
{
    internal class AccountConfiguration : IEntityTypeConfiguration<Account>
    {
        public void Configure(EntityTypeBuilder<Account> builder)
        {
            builder.ToTable("account");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired(true);

            builder.HasIndex(x => x.ExternalUserId).IsUnique(true);
            builder.Property(x => x.ExternalUserId).IsRequired(true);

            builder.Property(x => x.Type).IsRequired();
            builder.Property(x => x.PathToProfilePicture).IsRequired(false);
            builder.Property(x => x.Description).IsRequired(false);

            builder.Property(x => x.CreatedAt).IsRequired(true);
            builder.Property(x => x.UpdatedAt).IsRequired(false);
            builder.Property(x => x.IsDeleted).IsRequired(true);
        }
    }
}
