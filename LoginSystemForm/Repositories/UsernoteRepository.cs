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
    internal class UsernoteRepository
    {
        public UsernoteRepository()
        {
            db = new HomeworkContext();
        }

        HomeworkContext db;

        internal List<UserNote> NoteListByUser(User user)
        {
            return db.UserNotes.Where(note => note.UserId == user.Id).ToList();
        }

        internal bool NoteAdd(UserNote usernote)
        {
            db.UserNotes.Add(usernote);
            return db.SaveChanges() > 0;
        }

        internal bool NoteDelete(UserNote usernote)
        {
            db.UserNotes.Remove(usernote);
            return db.SaveChanges() > 0;
        }

        internal bool NoteUpdate(UserNote usernote)
        {
            db.UserNotes.Update(usernote);
            return db.SaveChanges() > 0;
        }

        internal UserNote NoteFind(int usernoteId)
        {
            return db.UserNotes.Where(u => u.Id == usernoteId).SingleOrDefault();
        }
        
        internal UserNote NoteFind(string title)
        {
            return db.UserNotes.Where(u => u.Title == title).SingleOrDefault();
        }
    }
}
