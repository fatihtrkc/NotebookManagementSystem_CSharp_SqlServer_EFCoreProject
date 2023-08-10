using EFCore_NoteBook.Context;
using EFCore_NoteBook.Entities;
using LoginSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_NoteBook.Repositories
{
    internal class UserRepository
    {
        public UserRepository()
        {
            db = new HomeworkContext();
        }

        HomeworkContext db;

        internal List<User> UserListByAdminId(int adminId)
        {
            return db.Users.Where(u => u.AdminId == adminId).ToList();
        }

        internal bool UserAdd(User userAdd)
        {
            db.Users.Add(userAdd);
            return db.SaveChanges() > 0;
        }

        internal bool UserUpdate(User userUpdt)
        {
            db.Users.Update(userUpdt);
            return db.SaveChanges() > 0;
        }


        User user;  //  User Username and Password have not null unique constraints.
        /// <summary>
        /// This method returns user.
        /// usernameIsFind parameter is returns that if system has username, true; else false.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="usernameIsFind"></param>
        /// <returns></returns>
        internal User UserFind(string username, string password, out bool usernameIsFind)
        {
            usernameIsFind = false;
            user = db.Users.Where(u => u.Username == username && u.Password == password).SingleOrDefault();

            if (user is not null)
            {
                usernameIsFind = true;
                return user;
            }
            else
            {
                bool IsUsernameFind = UsernameFind(username);

                if (IsUsernameFind) usernameIsFind = true;
                else usernameIsFind = false;

                return null;
            }
        }

        internal User UserFind(string username)
        {
            user = db.Users.Where(u => u.Username == username).SingleOrDefault();

            if (user is not null) return user;
            else return null;
        }

        public bool UsernameFind(string username)
        {
            user = db.Users.Where(user => user.Username == username).SingleOrDefault();

            if (user is not null) return true;
            else return false;
        }

        public bool PasswordFind(string password)
        {
            user = db.Users.Where(user => user.Password == password).SingleOrDefault();
            if (user is not null) return true;
            else return false;
        }
    }
}
