using EFCore_NoteBook;
using EFCore_NoteBook.Utility;
using LoginSystem;
using LoginSystem.Models;

namespace LoginSystemForm
{
    internal partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private void LoginSystemForm_Load(object sender, EventArgs e)
        {
            ToolSet.PasswordChar(this.Controls, true);
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtUsername.Text) && !string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                string message = "";

                int adminSituation = Manager.IsAdmin(this, ref message);

                if (adminSituation == 0) MessageBox.Show(message, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (adminSituation == -1)
                {
                    int userSituation = Manager.IsUser(this, ref message);

                    if (userSituation == 0) MessageBox.Show(message, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else if (userSituation == -1)
                    {
                        DialogResult dialogResult = MessageBox.Show(message, "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (DialogResult.Yes == dialogResult)
                        {
                            this.Hide();
                            RegisterForm registerForm = new RegisterForm(txtUsername.Text, txtPassword.Text);
                            ToolSet.Clear(this.Controls);
                            registerForm.ShowDialog();
                            this.Show();
                        }
                    }
                }
            }
            else MessageBox.Show("Please enter your username and password !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void lnklblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ToolSet.Clear(this.Controls);
            RegisterForm form = new RegisterForm();
            form.ShowDialog();
        }
    }
}