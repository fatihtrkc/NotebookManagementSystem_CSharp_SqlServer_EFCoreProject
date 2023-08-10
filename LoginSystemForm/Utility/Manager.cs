using EFCore_NoteBook.Entities;
using EFCore_NoteBook.Repositories;
using LoginSystem;
using LoginSystem.Models;
using LoginSystemForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_NoteBook.Utility
{
    internal static class Manager
    {
        static AdminRepository adminRepository;
        static UsernoteRepository usernoteRepository;
        static UserRepository userRepository;

        static Admin admin;
        static UserNote userNote;
        static User user;

        static string name, surname, username, password;
        static bool usernameIsFind, passwordIsFind;

        /// <summary>
        /// IsAdmin method that if admin is registered in the system, returns 1; else if admin is not registered but username is registered, returns 0; else returns -1.
        /// </summary>
        /// <param name="form"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public static int IsAdmin(LoginForm form, ref string message)
        {
            adminRepository = new AdminRepository();

            ToolSet.AssignInfo(form.Controls, ref username, ref password);

            admin = adminRepository.AdminFind(username, password, out usernameIsFind);

            if (admin is not null)
            {
                ToolSet.Clear(form.Controls);
                form.Hide();
                AdminForm adminForm = new AdminForm(admin);
                adminForm.ShowDialog();
                form.Show();
                return 1;  //  Admin is found.
            }
            else
            {
                if (usernameIsFind)
                {
                    message = "Entered password is incorrect !";
                    return 0;  //  Admin is not found but username is registered in the system.
                }
                else
                {
                    message = "Login failed ! This username doesn't exist in the system.\nWould you like to sign up?";
                    return -1;  //  Admin is not found, username is not registered in the system.
                }
            }
        }

        /// <summary>
        /// IsUser method that if admin is registered in the system, returns 1; else if admin is not registered but username is registered, returns 0; else returns -1.
        /// </summary>
        /// <param name="form"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public static int IsUser(LoginForm form, ref string message)
        {
            userRepository = new UserRepository();

            ToolSet.AssignInfo(form.Controls, ref username, ref password);

            user = userRepository.UserFind(username, password, out usernameIsFind);

            if (user is not null)
            {
                if (user.Situation)
                {
                    ToolSet.Clear(form.Controls);
                    form.Hide();
                    MainForm mainForm = new MainForm(user);
                    mainForm.ShowDialog();
                    form.Show();
                    return 1;  //  User is found.
                }
                else
                {
                    message = "This registration has not been confirmed yet !\nPlease contact with administrator.";
                    return 0;
                }
            }
            else
            {
                if (usernameIsFind)
                {
                    message = "Entered password is incorrect !";
                    return 0;  //  User is not found but username is registered in the system.
                }
                else
                {
                    message = "Login failed ! This username doesn't exist in the system.\nWould you like to sign up?";
                    return -1;  //  User is not found, username is not registered in the system.
                }
            }
        }

        /// <summary>
        /// IsAdmin method that if username and password is not registered in the system, returns 1; else if username or password is not registered, returns 0; else returns -1.
        /// </summary>
        /// <param name="form"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public static int IsAdmin(RegisterForm form, ref string message)
        {
            adminRepository = new AdminRepository();

            ToolSet.AssignInfo(form.Controls, ref username, ref password);

            usernameIsFind = adminRepository.UsernameFind(username);
            passwordIsFind = adminRepository.PasswordFind(password);

            if (!usernameIsFind && !passwordIsFind)
            {
                message = "";
                return 1;  //  Admin is found.
            }
            else if (usernameIsFind && !passwordIsFind)
            {
                message = "This username can not be used !";
                return 0;
            }
            else if (!usernameIsFind && passwordIsFind)
            {
                message = "This password can not be used !";
                return 0;
            }
            else
            {
                message = "This username and password can not be used !";
                return -1;  //  Admin is not found, username is not registered in the system.
            }
        }

        /// <summary>
        /// IsUser method that if username and password is not registered in the system, returns 1; else if admin is not registered but username is registered, returns 0; else returns -1.
        /// If returns 1, new user is added to the system.
        /// </summary>
        /// <param name="form"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public static int IsUser(RegisterForm form, ref string message)
        {
            userRepository = new UserRepository();

            ToolSet.AssignInfo(form.Controls, ref name, ref surname, ref username, ref password);

            bool usernameSituation = userRepository.UsernameFind(username);
            bool passwordSituation = userRepository.PasswordFind(password);

            if (!usernameSituation && !passwordSituation)
            {
                user = new User()
                {
                    Name = name,
                    Surname = surname,
                    Username = username,
                    Password = password
                };

                bool IsAdded = userRepository.UserAdd(user);
                if (IsAdded)
                {
                    message = $"New user is added to the system.\n\nUsername : {username}\nPassword : {password}";
                    form.Close();
                    return 1;
                }
                else
                {
                    message = "New user could not be added !\nPlease try again later.";
                    return -1;
                }
            }
            else if (usernameIsFind && !passwordIsFind)
            {
                message = "This username can not be used !";
                return 0;
            }
            else if (!usernameIsFind && passwordIsFind)
            {
                message = "This password can not be used !";
                return 0;
            }
            else
            {
                message = "This username and password can not be used !";
                return -1;  //  User is not found, username is not registered in the system.
            }
        }

        /// <summary>
        /// GetUsersByAdminByUser method that if userUsername is not null, before user is updated after users is listed to datagridview; else only users is listed to datagridview.
        /// </summary>
        /// <param name="form"></param>
        /// <param name="getAdmin"></param>
        /// <param name="userUsername"></param>
        /// <returns></returns>
        public static bool GetUsersByAdminByUser(AdminForm form, Admin getAdmin, string userUsername)
        {
            userRepository = new UserRepository();

            if (!string.IsNullOrWhiteSpace(userUsername))
            {
                user = userRepository.UserFind(userUsername);
                if (user is not null)
                {
                    user.Situation = (user.Situation == true ? false : true);
                    userRepository.UserUpdate(user);
                }
            }

            foreach (Control control in form.Controls)
            {
                if (control is DataGridView)
                {
                    ((DataGridView)control).DataSource = userRepository.UserListByAdminId(getAdmin.Id).
                        Select(u => new { u.Name, u.Surname, u.Username, u.Situation }).ToList();
                    ((DataGridView)control).ClearSelection();
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Listbox selected item value member is equal to UserNote' s Id value.
        /// If usernoteId is in database, get userNote from UserRepository' s NoteFind method.
        /// Later userNote is sent to ToolSet classes AssignInfo method.
        /// </summary>
        /// <param name="form"></param>
        /// <param name="usernoteId"></param>
        public static void ToolFill(MainForm form, int usernoteId)
        {
            usernoteRepository = new UsernoteRepository();

            userNote = usernoteRepository.NoteFind(usernoteId);

            if (userNote is not null)
            {
                ToolSet.AssignInfo(form.Controls, userNote);
            }
        }

        public static bool GetNotesByUser(MainForm form, User getUser)
        {
            usernoteRepository = new UsernoteRepository();

            foreach (Control control in form.Controls)
            {
                if (control is ListBox)
                {
                    ListBox listBox = (ListBox)control;
                    listBox.DisplayMember = "Title";
                    listBox.ValueMember = "Id";
                    listBox.DataSource = usernoteRepository.NoteListByUser(getUser);
                    listBox.SelectedItems.Clear();
                    return true;
                }
            }
            return false;
        }

        public static string AddNewNote(MainForm form, User getUser, string title, string content)
        {
            usernoteRepository = new UsernoteRepository();

            if (usernoteRepository.NoteFind(title) is null)
            {
                userNote = new UserNote()
                {
                    Title = title,
                    Content = content,
                    UserId = getUser.Id
                };

                bool IsAdded = usernoteRepository.NoteAdd(userNote);
                if (!IsAdded) return "New note was not added !";

                bool IsListed = GetNotesByUser(form, getUser);
                if (!IsListed) return "Your notes were not listed !";

                return null;
            }
            else return "This Title can not be used !\nThere is a register that was already added with this title.";
        }

        public static string UpdateNote(MainForm form, User getUser, int usernoteId, string title, string content)
        {
            usernoteRepository = new UsernoteRepository();

            userNote = usernoteRepository.NoteFind(usernoteId);

            if (userNote is not null)
            {
                userNote.Title = title;
                userNote.Content = content;

                bool IsUpdated = usernoteRepository.NoteUpdate(userNote);
                if (!IsUpdated) return "This note was not updated !";

                bool IsListed = GetNotesByUser(form, getUser);
                if (!IsListed) return "Your notes were not listed !";

                return null;
            }
            else return "This user note was not found !\nAn error may be occured, plese try again.";
        }

        public static string DeleteNote(MainForm form, User getUser, int usernoteId)
        {
            usernoteRepository = new UsernoteRepository();

            userNote = usernoteRepository.NoteFind(usernoteId);

            if (userNote is not null)
            {
                bool IsDeleted = usernoteRepository.NoteDelete(userNote);
                if (!IsDeleted) return "This note was not deleted !";

                bool IsListed = GetNotesByUser(form, getUser);
                if (!IsListed) return "Your notes were not listed !";

                return null;
            }
            else return "This user note was not found !\nAn error may be occured, plese try again.";
        }

        public static string UpdateUserPassword(PasswordForm form, User getUser, string new_password)
        {
            userRepository = new UserRepository();

            user = userRepository.UserFind(getUser.Username);

            if (user is not null)
            {
                getUser.Password = new_password;
                bool IsUpdated = userRepository.UserUpdate(user);
                if (!IsUpdated) return "This user was not updated !";

                ToolSet.Clear(form.Controls);
                return $"Upload is succeeded !\nNew password : {new_password}";
            }
            else return "This user note was not found !\nAn error may be occured, plese try again.";
        }
    }
}
