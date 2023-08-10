using System;
using System.Collections.Generic;
using EFCore_NoteBook.Entities;
using LoginSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EFCore_NoteBook.Context
{
    internal class HomeworkContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<Admin> Admins { get; set; }
        public DbSet<UserNote> UserNotes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=NotebookDb;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(HomeworkContext).Assembly);
        }
    }
}
