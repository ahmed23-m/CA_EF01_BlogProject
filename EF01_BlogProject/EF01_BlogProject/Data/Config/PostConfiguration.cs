using EF01_BlogProject.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF01_BlogProject.Data.Config
{
    public class PostConfiguration : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.HasKey(p => p.PostID);
            builder.Property(p => p.PostID).ValueGeneratedNever();

            builder.Property(p => p.Title)
                .HasColumnType("VARCHAR")
                .HasMaxLength(255)
                .IsRequired();

            builder.Property(p => p.Content)
                .HasColumnType("VARCHAR")
                .HasMaxLength(500)
                .IsRequired();

            builder.Property(p => p.CreatedAt)
                .HasColumnType("DATETIME2")
                .IsRequired();

            // Configure Post-Comment relationship 
            // Post-Comment Relationship: Cascade deletion of Comments when a Post is deleted
            builder.HasMany(p => p.Comments)
                    .WithOne(c => c.Post)
                    .HasForeignKey(c => c.PostID)
                    .IsRequired()
                    .OnDelete(DeleteBehavior.Cascade);

        }


    }
}
