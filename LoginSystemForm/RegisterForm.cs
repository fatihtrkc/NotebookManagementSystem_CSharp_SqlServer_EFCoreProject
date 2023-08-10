using EFCore_NoteBook;
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

namespace LoginSystem
{
    internal partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }
        public RegisterForm(string username, string password)
        {
            InitializeComponent();
            txtUsername.Text = username;
            txtPassword.Text = password;
            txtPasswordConfirm.Text = password;
        }
        private void RegisterSystemForm_Load(object sender, EventArgs e)
        {
            ToolSet.PasswordChar(this.Controls, true);
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            string name = txtName.Text, surname = txtSurname.Text, username = txtUsername.Text, password = txtPassword.Text;

            if (!string.IsNullOrWhiteSpace(name) && !string.IsNullOrWhiteSpace(surname) && !string.IsNullOrWhiteSpace(username) &&
                !string.IsNullOrWhiteSpace(password) && (password == txtPasswordConfirm.Text))
            {
                string message = "";

                int adminSituation = Manager.IsAdmin(this, ref message);

                if (adminSituation == 0 || adminSituation == -1) MessageBox.Show(message, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                else
                {
                    int userSituation = Manager.IsUser(this, ref message);

                    if (userSituation == 1) MessageBox.Show(message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else if (userSituation == 0 || userSituation == -1) MessageBox.Show(message, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }

            else if (!string.IsNullOrWhiteSpace(name) && !string.IsNullOrWhiteSpace(surname) && !string.IsNullOrWhiteSpace(username) &&
                !string.IsNullOrWhiteSpace(password) && (password != txtPasswordConfirm.Text))
            {
                MessageBox.Show("Entered password are not the same !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(surname) || string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(txtPasswordConfirm.Text))
            {
                MessageBox.Show("Please fill in the all fields !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        int counter = 0;
        void TextChangeAlert()
        {
            if (txtPassword.Text != txtPasswordConfirm.Text)
            {
                timer.Start();
                lblPassMatch.Visible = true;
            }
            else
            {
                timer.Stop();
                counter = 0;
                pctrbxAlert.Visible = false;
                lblPassMatch.Visible = false;
            }
        }
        private void txtConfirmPass_TextChanged(object sender, EventArgs e)
        {
            TextChangeAlert();
        }
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            TextChangeAlert();
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            counter++;
            if (counter % 3 == 0) pctrbxAlert.Visible = true;
            else pctrbxAlert.Visible = false;
        }

        private void checkbxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbxShowPass.Checked)
            {
                ToolSet.PasswordChar(this.Controls, false);
            }
            else
            {
                ToolSet.PasswordChar(this.Controls, true);
            }
        }
        private void pctrbxExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void pctrbxExit_MouseHover(object sender, EventArgs e)
        {
            pctrbxExit.BackColor = Color.Red;
        }
        private void pctrbxExit_MouseLeave(object sender, EventArgs e)
        {
            pctrbxExit.BackColor = default;
        }
    }
}
