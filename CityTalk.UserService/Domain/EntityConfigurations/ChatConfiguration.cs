using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.EntityConfigurations
{
    internal class ChatConfiguration : IEntityTypeConfiguration<Chat>
    {
        public void Configure(EntityTypeBuilder<Chat> builder)
        {
            builder.ToTable("chat");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired(true);

            builder.Property(x => x.Type).IsRequired(true);
            builder.Property(x => x.PathToPicture).IsRequired(false);
            builder.Property(x => x.Name).IsRequired(false);
            builder.Property(x => x.Description).IsRequired(false);

            builder.Property(x => x.MemberBinds).IsRequired(false);
            builder.HasOne(x => x.MemberBinds)
                .WithMany()
                .OnDelete(DeleteBehavior.Cascade);

            builder.Property(x => x.CreatedAt).IsRequired(true);
            builder.Property(x => x.UpdatedAt).IsRequired(false);
            builder.Property(x => x.IsDeleted).IsRequired(true);
        }
    }
}
