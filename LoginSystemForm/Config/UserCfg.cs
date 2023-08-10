using LoginSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_NoteBook.Config
{
    internal class UserCfg : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(user => user.Name).HasColumnType("nvarchar").HasMaxLength(20).IsRequired();
            builder.Property(user => user.Surname).HasColumnType("nvarchar").HasMaxLength(20).IsRequired();
            builder.Property(user => user.Username).HasColumnType("nvarchar").HasMaxLength(20).IsRequired();
            builder.HasIndex(user => user.Username).IsUnique();
            builder.Property(user => user.Password).HasColumnType("nvarchar").HasMaxLength(20).IsRequired();
            builder.HasIndex(user => user.Password).IsUnique();
            builder.Property(user => user.Situation).HasDefaultValue(false);
            builder.Property(user => user.AdminId).HasDefaultValue(1);
        }
    }
}
