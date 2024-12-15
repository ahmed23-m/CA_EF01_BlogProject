using EF01_BlogProject.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF01_BlogProject.Data.Config
{
    public class CommentConfiguration : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.HasKey(c =>c.CommentID);
            builder.Property(c => c.CommentID).ValueGeneratedNever();

            builder.Property(p => p.Content)
                .HasColumnType("VARCHAR")
                .HasMaxLength(500)
                .IsRequired();

            builder.Property(p => p.CreatedAt)
                .HasColumnType("DATETIME")
                .IsRequired();

        }

    }
}
