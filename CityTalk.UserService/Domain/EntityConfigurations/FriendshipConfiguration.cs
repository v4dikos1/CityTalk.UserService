using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.EntityConfigurations
{
    public class FriendshipConfiguration : IEntityTypeConfiguration<Friendship>
    {
        public void Configure(EntityTypeBuilder<Friendship> builder)
        {
            builder.ToTable("friendship");
            builder.HasIndex(x => new { x.TargetUserId, x.SourceUserId });

            builder.Property(x => x.SourceUserId).IsRequired();
            builder.HasOne(x => x.SourceUser)
                .WithMany()
                .HasForeignKey(x => x.SourceUserId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Property(x => x.TargetUserId).IsRequired();
            builder.HasOne(x => x.TargetUser)
                .WithMany()
                .HasForeignKey(x => x.TargetUserId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Property(x => x.Status).IsRequired();
            builder.Property(x => x.CreatedAt).IsRequired();
            builder.Property(x => x.UpdatedAt);
        }
    }
}
