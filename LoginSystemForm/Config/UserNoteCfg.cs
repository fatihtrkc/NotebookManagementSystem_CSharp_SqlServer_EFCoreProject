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
    internal class UserNoteCfg : IEntityTypeConfiguration<UserNote>
    {
        public void Configure(EntityTypeBuilder<UserNote> builder)
        {
            builder.Property(note => note.Title).HasColumnType("nvarchar").HasMaxLength(50).IsRequired();
            builder.HasIndex(note => note.Title).IsUnique();
            builder.Property(note => note.Content).HasColumnType("text").IsRequired();
        }
    }
}
