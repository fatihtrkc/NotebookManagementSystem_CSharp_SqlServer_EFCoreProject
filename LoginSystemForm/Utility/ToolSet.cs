using EFCore_NoteBook.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace EFCore_NoteBook.Utility
{
    internal static class ToolSet
    {
        public static void PasswordChar(Control.ControlCollection controlCollection, bool checkedValue)
        {
            foreach (Control control in controlCollection)
            {
                if (control is TextBox)
                {
                    if (((TextBox)control).Name.Contains("Password"))
                    {
                        ((TextBox)control).UseSystemPasswordChar = checkedValue;
                    }
                }
            }
        }

        public static void Clear(Control.ControlCollection controlCollection)
        {
            foreach (Control control in controlCollection)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
                else if (control is CheckBox)
                {
                    ((CheckBox)control).Checked = false;
                }
                else if (control is ListBox)
                {
                    ((ListBox)control).SelectedItems.Clear();
                }
            }
        }

        public static void AssignInfo(Control.ControlCollection controlCollection, ref string username, ref string password)
        {
            foreach (Control control in controlCollection)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    if (textBox.Name.Contains("Username"))
                    {
                        username = textBox.Text;
                    }
                    else if (textBox.Name.Contains("Password"))
                    {
                        password = textBox.Text;
                    }
                }
            }
        }

        public static void AssignInfo(Control.ControlCollection controlCollection, ref string name, ref string surname, ref string username, ref string password)
        {
            foreach (Control control in controlCollection)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    if (textBox.Name.Contains("Name"))
                    {
                        name = textBox.Text;
                    }
                    else if (textBox.Name.Contains("Surname"))
                    {
                        surname = textBox.Text;
                    }
                    else if (textBox.Name.Contains("Username"))
                    {
                        username = textBox.Text;
                    }
                    else if (textBox.Name.Select(text => text.ToString() == "Password").FirstOrDefault())
                    {
                        password = textBox.Text;
                    }
                }
            }
        }

        public static void AssignInfo(Control.ControlCollection controlCollection, UserNote userNote)
        {
            foreach (Control control in controlCollection)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    if (textBox.Name.Contains("Title"))
                    {
                        textBox.Text = userNote.Title;
                    }
                    else if (textBox.Name.Contains("Content"))
                    {
                        textBox.Text = userNote.Content;
                    }
                }
            }
        }

        /// <summary>
        /// Only one value is true from listbxIsSelected and IsNewNote values. Because If IsNewNote is true, listbox selected items will be clear. 
        /// </summary>
        /// <param name="controlCollection"></param>
        /// <param name="listbxIsSelected"></param>
        /// <param name="IsNewNote"></param>
        public static void Change(Control.ControlCollection controlCollection, bool listbxIsSelected, bool IsNewNote)
        {
            if ((listbxIsSelected && !IsNewNote) || (!listbxIsSelected && !IsNewNote))
            {
                foreach (Control control in controlCollection)
                {
                    if (control is TextBox)
                    {
                        ((TextBox)control).Enabled = listbxIsSelected;
                    }
                    if (control is Button)
                    {
                        Button button = (Button)control;
                        if (button.Name.Contains("Delete"))
                        {
                            button.Enabled = listbxIsSelected;
                        }
                        else if (button.Name.Contains("Save"))
                        {
                            if (listbxIsSelected)
                            {
                                button.Enabled = true;
                                button.Text = "Note Update";
                            }
                            else
                            {
                                button.Enabled = false;
                                button.Text = "Note Save";
                            }
                        }
                    }
                }
            }

            else if (!listbxIsSelected && IsNewNote)
            {
                foreach (Control control in controlCollection)
                {
                    if (control is TextBox)
                    {
                        TextBox textBox = (TextBox)control;
                        textBox.Enabled = IsNewNote;
                        if (textBox.Name.Contains("Title")) textBox.Focus();
                    }
                    if (control is Button)
                    {
                        Button button = (Button)control;
                        if (button.Name.Contains("Delete"))
                        {
                            button.Enabled = !IsNewNote;
                        }
                        else if (button.Name.Contains("Save"))
                        {
                            button.Enabled = IsNewNote;
                            button.Text = "Note Save";
                        }
                    }
                }
            }
        }
    }
}
