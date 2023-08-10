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
using System.Xml.Linq;

namespace EFCore_NoteBook
{
    internal partial class PasswordForm : Form
    {
        public PasswordForm(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        User user;
        private void PasswordForm_Load(object sender, EventArgs e)
        {
            ToolSet.PasswordChar(this.Controls, true);
            txtPasswordOld.Enabled = false;
            txtPasswordOld.Text = user.Password;
        }
        private void btnPasswordUpdt_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtPasswordNew.Text) && (txtPasswordNew.Text == txtPasswordNewConfirm.Text))
            {
                string message = Manager.UpdateUserPassword(this, user, txtPasswordNew.Text);

                MessageBox.Show(message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            else if (txtPasswordNew.Text != txtPasswordNewConfirm.Text)
            {
                MessageBox.Show("Entered password are not the same !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(txtPasswordNew.Text) || string.IsNullOrWhiteSpace(txtPasswordNewConfirm.Text))
            {
                MessageBox.Show("Please fill in the password and password confirm fields !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        int counter = 0;
        void TextChangeAlert()
        {
            if (txtPasswordNew.Text != txtPasswordNewConfirm.Text)
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
        private void txtPasswordNew_TextChanged(object sender, EventArgs e)
        {
            TextChangeAlert();
        }
        private void txtPasswordNewConfirm_TextChanged(object sender, EventArgs e)
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
