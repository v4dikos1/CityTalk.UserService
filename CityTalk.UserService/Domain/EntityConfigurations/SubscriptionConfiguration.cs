using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.EntityConfigurations
{
    public class SubscriptionConfiguration : IEntityTypeConfiguration<Subscription>
    {
        public void Configure(EntityTypeBuilder<Subscription> builder)
        {
            builder.ToTable("subscription");
            builder.HasIndex(x => new { x.UserId, x.BusinessUserId });

            builder.Property(x => x.UserId).IsRequired();
            builder.HasOne(x => x.User)
                .WithMany()
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Property(x => x.BusinessUserId).IsRequired();
            builder.HasOne(x => x.BusinessUser)
                .WithMany()
                .HasForeignKey(x => x.BusinessUserId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Property(x => x.CreatedAt).IsRequired();
        }
    }
}
