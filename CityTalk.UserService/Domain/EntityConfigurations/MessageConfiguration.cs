using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.EntityConfigurations
{
    public class MessageConfiguration : IEntityTypeConfiguration<Message>
    {
        public void Configure(EntityTypeBuilder<Message> builder)
        {
            builder.ToTable("message");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired();

            builder.Property(x => x.UserTypeBindId).IsRequired();
            builder.HasOne(x => x.UserTypeBind)
                .WithMany()
                .HasForeignKey(x => x.UserTypeBindId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Property(x => x.RootMessageId);
            builder.HasOne(x => x.RootMessage)
                .WithMany()
                .HasForeignKey(x = x => x.RootMessage.Id)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Property(x => x.Content).IsRequired();
            builder.Property(x => x.Attachment);
            builder.Property(x => x.IsReaded).IsRequired();

            builder.Property(x => x.CreatedAt).IsRequired();
            builder.Property(x => x.UpdatedAt);
            builder.Property(x => x.IsDeleted).IsRequired();
        }
    }
}
