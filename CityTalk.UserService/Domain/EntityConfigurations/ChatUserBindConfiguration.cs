using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.EntityConfigurations
{
    internal class ChatUserBindConfiguration : IEntityTypeConfiguration<ChatUserBind>
    {
        public void Configure(EntityTypeBuilder<ChatUserBind> builder)
        {
            builder.ToTable("chat_user_bind");
            builder.HasKey(x => new { x.ChatId, x.MemberId });

            builder.Property(x => x.ChatId).IsRequired(true);
            builder.HasOne(x => x.Chat)
                .WithMany()
                .HasForeignKey(x => x.ChatId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Property(x => x.MemberId).IsRequired(true);
            builder.HasOne(x => x.Member)
                .WithMany()
                .HasForeignKey(x => x.MemberId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Property(x => x.JoinedAt).IsRequired(true);
        }
    }
}
