using EFCore_NoteBook.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_NoteBook.Config
{
    internal class AdminCfg : IEntityTypeConfiguration<Admin>
    {
        public void Configure(EntityTypeBuilder<Admin> builder)
        {
            builder.Property(user => user.Username).HasColumnType("nvarchar").HasMaxLength(20).IsRequired();
            builder.HasIndex(user => user.Username).IsUnique();
            builder.Property(user => user.Password).HasColumnType("nvarchar").HasMaxLength(20).IsRequired();
            builder.HasIndex(user => user.Password).IsUnique();
            builder.HasData
                (
                new Admin() { Id = 1, Username = "admin", Password = "1234" }
                );
        }
    }
}
