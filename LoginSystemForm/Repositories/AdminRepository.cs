using EFCore_NoteBook.Context;
using EFCore_NoteBook.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace EFCore_NoteBook.Repositories
{
    internal class AdminRepository
    {
        public AdminRepository() 
        {
            db = new HomeworkContext();
        }

        HomeworkContext db;
        Admin admin;  // Admin Username and Password have not null unique constraints.

        /// <summary>
        /// This method returns admin.
        /// usernameIsFind parameter is returns that if system has username, true; else false.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="usernameIsFind"></param>
        /// <returns></returns>
        public Admin AdminFind(string username, string password, out bool usernameIsFind)
        {
            usernameIsFind = false;
            admin = db.Admins.Where(a => a.Username == username && a.Password == password).SingleOrDefault();

            if (admin is not null)
            {
                usernameIsFind = true;
                return admin;
            }
            else
            {
                bool IsUsernameFind = UsernameFind(username);

                if (IsUsernameFind) usernameIsFind = true;
                else usernameIsFind = false;

                return null;
            }
        }

        public bool UsernameFind(string username)
        {
            admin = db.Admins.Where(admin => admin.Username == username).SingleOrDefault();

            if (admin is not null) return true;
            else return false;
        }

        public bool PasswordFind(string password) 
        {
            admin = db.Admins.Where(admin => admin.Password == password).SingleOrDefault();
            if (admin is not null) return true;
            else return false;
        }
    }
}
