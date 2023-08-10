using LoginSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_NoteBook.Entities
{
    internal class Admin
    {
        public Admin() 
        {
            Users = new List<User>();
        }

        public int Id { get; set; }  // primary key
        public string Username { get; set; }  // not null, unique
        public string Password { get; set; }  //  not null, unique

        //Relations
        public ICollection<User> Users { get; set; }
    }
}
