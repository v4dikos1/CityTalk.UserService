using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.EntityConfigurations
{
    public class ChatConfiguration : IEntityTypeConfiguration<Chat>
    {
        public void Configure(EntityTypeBuilder<Chat> builder)
        {
            builder.ToTable("chat");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired();

            builder.Property(x => x.Name).IsRequired();
            builder.Property(x => x.Description);

            builder.Property(x => x.CreatedAt).IsRequired();
            builder.Property(x => x.UpdatedAt);
            builder.Property(x => x.IsDeleted).IsRequired();
        }
    }
}
