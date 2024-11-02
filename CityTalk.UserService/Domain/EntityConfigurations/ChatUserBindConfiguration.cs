using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.EntityConfigurations
{
    public class ChatUserBindConfiguration : IEntityTypeConfiguration<ChatUserBind>
    {
        public void Configure(EntityTypeBuilder<ChatUserBind> builder)
        {
            builder.ToTable("chat_user_bind");
            builder.HasIndex(x => new { x.ChatId, x.UserTypeBindId });

            builder.Property(x => x.ChatId).IsRequired();
            builder.HasOne(x => x.Chat)
                .WithMany()
                .HasForeignKey(x => x.ChatId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Property(x => x.UserTypeBindId).IsRequired();
            builder.HasOne(x => x.UserTypeBind)
                .WithMany()
                .HasForeignKey(x => x.UserTypeBindId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Property(x => x.JoinedAt).IsRequired();
        }
    }
}
