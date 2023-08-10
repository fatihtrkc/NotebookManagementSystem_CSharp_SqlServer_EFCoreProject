using LoginSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_NoteBook.Entities
{
    internal class UserNote
    {
        public int Id { get; set; }  // primary key
        public string Title { get; set; }  //  not null, unique
        public string Content { get; set; }  // not null

        //Relations
        [ForeignKey("User")]
        public int UserId { get; set; }  // foreign key
        public User User { get; set; }
    }
}
