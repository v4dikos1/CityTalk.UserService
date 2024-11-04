using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.EntityConfigurations
{
    internal class MessageConfiguration : IEntityTypeConfiguration<Message>
    {
        public void Configure(EntityTypeBuilder<Message> builder)
        {
            builder.ToTable("message");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired(true);

            builder.Property(x => x.SenderId).IsRequired(true);
            builder.HasOne(x => x.Sender)
                .WithMany()
                .HasForeignKey(x => x.SenderId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Property(x => x.RootMessageId).IsRequired(false);
            builder.HasOne(x => x.RootMessage)
                .WithMany()
                .HasForeignKey(x => x.RootMessageId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Property(x => x.Content).IsRequired(true);

            /*
            builder.Property(x => x.Attachments).IsRequired(false);
            builder.HasMany(x => x.Attachments)
                .WithOne()
                .OnDelete(DeleteBehavior.Cascade);

            builder.Property(x => x.WhoRead).IsRequired(false);
            builder.HasMany(x => x.WhoRead)
                .WithOne()
                .OnDelete(DeleteBehavior.Cascade);*/

            builder.Property(x => x.CreatedAt).IsRequired(true);
            builder.Property(x => x.UpdatedAt).IsRequired(false);
            builder.Property(x => x.IsDeleted).IsRequired(true);
        }
    }
}
