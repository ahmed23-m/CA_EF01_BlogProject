using EF01_BlogProject.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace EF01_BlogProject.Data.Config
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u => u.ID);
            builder.Property(u => u.ID).ValueGeneratedNever();

            builder.Property(u => u.UserName)
                .HasColumnType("VARCHAR")
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(u => u.Password)
                .HasColumnType("VARCHAR")
                .HasMaxLength(50)
                .IsRequired();

            // Configure User-Post relationship from User side
            // User-Post Relationship: Cascade deletion of Posts when a User is deleted
            builder.HasMany(u => u.Posts) // A User has many Posts
                    .WithOne(p => p.Author) // Each Post has one Author
                    .HasForeignKey(p => p.AuthorID) // Foreign key in Post
                    .IsRequired()
                    .OnDelete(DeleteBehavior.Cascade);

            // Configure User-Comment relationship
            // User-Comment Relationship: Prevent multiple cascade paths by using Restrict or SetNull
            builder.HasMany(u => u.Comments)
                    .WithOne(c => c.Author)
                    .HasForeignKey(c => c.AuthorID)
                    .IsRequired(false);

        }

    }
}
