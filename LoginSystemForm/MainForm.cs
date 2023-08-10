using EFCore_NoteBook.Utility;
using LoginSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFCore_NoteBook
{
    internal partial class MainForm : Form
    {
        public MainForm(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        User user;
        private void MainForm_Load(object sender, EventArgs e)
        {
            bool processIsOK = Manager.GetNotesByUser(this, user);
            if (!processIsOK)
            {
                MessageBox.Show("An error has occured in the system !\nPlease try to log in to the system again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            ToolSet.Clear(this.Controls);
            ToolSet.Change(this.Controls, false, false);
        }

        string message;
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtTitle.Text) && !string.IsNullOrWhiteSpace(txtContent.Text))
            {
                if (btnSave.Text == "Note Save" && lstbxMynotes.SelectedItems.Count == 0)
                {
                    message = Manager.AddNewNote(this, user, txtTitle.Text, txtContent.Text);

                    if (message is not null) MessageBox.Show(message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (btnSave.Text == "Note Update" && lstbxMynotes.SelectedItems.Count == 1)
                {
                    message = Manager.UpdateNote(this, user, usernoteId, txtTitle.Text, txtContent.Text);
                    if (message is not null) MessageBox.Show(message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else MessageBox.Show("Please fill in the Title and Content blanks !", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstbxMynotes.SelectedItems.Count == 1)
            {
                message = Manager.DeleteNote(this, user, usernoteId);

                if (message is not null) MessageBox.Show(message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            ToolSet.Clear(this.Controls);
            ToolSet.Change(this.Controls, false, true);
            txtTitle.Focus();
        }

        int usernoteId;
        private void lstbxMynotes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstbxMynotes.SelectedValue is int)
            {
                usernoteId = (int)(lstbxMynotes.SelectedValue);
                Manager.ToolFill(this, usernoteId);
                ToolSet.Change(this.Controls, true, false);
            }
            else
            {
                ToolSet.Clear(this.Controls);
                ToolSet.Change(this.Controls, false, false);
            }
        }
        private void lnklblChange_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PasswordForm form = new PasswordForm(user);
            this.Hide();
            form.ShowDialog();
            this.Show();
            ToolSet.Clear(this.Controls);
        }
    }
}
