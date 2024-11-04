using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.EntityConfigurations
{
    internal class UserReadMessageConfiguration : IEntityTypeConfiguration<UserReadMessage>
    {
        public void Configure(EntityTypeBuilder<UserReadMessage> builder)
        {
            builder.ToTable("user_read_message");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.UserId).IsRequired(true);

            builder.HasIndex(x => new { x.UserId, x.MessageId }).IsUnique(true);
            builder.Property(x => x.UserId).IsRequired(true);
            builder.HasOne(x => x.User)
                .WithMany()
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Property(x => x.MessageId).IsRequired(true);
            builder.HasOne(x => x.Message)
                .WithMany()
                .HasForeignKey(x => x.MessageId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Property(x => x.ReadAt).IsRequired(true);
        }
    }
}
