using EFCore_NoteBook.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace LoginSystem.Models
{
    internal class User
    {
        public User() 
        {
            UserNotes = new List<UserNote>();
        }

        public int Id { get; set; }  // primary key
        public string Name { get; set; }  //  not null
        public string Surname { get; set; }  //  not null
        public string Username { get; set; }  // not null, unique
        public string Password { get; set; }  // not null, unique
        public bool Situation { get; set; }  // default false

        //Relations
        [ForeignKey("Admin")]
        public int AdminId { get; set; } = 1;  // foreign key  default value 1(Admins table have 1 item.)
        public Admin Admin { get; set; }
        public ICollection<UserNote> UserNotes { get; set; }
    }
}
