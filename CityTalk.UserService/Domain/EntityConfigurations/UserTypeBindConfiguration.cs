using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.EntityConfigurations
{
    public class UserTypeBindConfiguration : IEntityTypeConfiguration<UserTypeBind>
    {
        public void Configure(EntityTypeBuilder<UserTypeBind> builder)
        {
            builder.ToTable("user_type");

            builder.HasIndex(x => x.UserId);
            builder.Property(x => x.UserId).IsRequired();
            builder.HasOne(x => x.User)
                .WithMany()
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Property(x => x.Type).IsRequired();
        }
    }
}
