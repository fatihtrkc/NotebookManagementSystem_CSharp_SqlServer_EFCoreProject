using EFCore_NoteBook.Entities;
using EFCore_NoteBook.Utility;
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
    internal partial class AdminForm : Form
    {
        public AdminForm(Admin admin)
        {
            InitializeComponent();
            this.admin = admin;
        }

        Admin admin;
        private void AdminForm_Load(object sender, EventArgs e)
        {
            bool AdminHaveUsers = Manager.GetUsersByAdminByUser(this, admin, userUsername);
            if (!AdminHaveUsers)
            {
                MessageBox.Show("Any user register was not found", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnActivePassive_Click(object sender, EventArgs e)
        {
            if (userUsername is not null)
            {
                Manager.GetUsersByAdminByUser(this, admin, userUsername);
            }
        }

        string userUsername;
        private void dtgridAdmin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                userUsername = (dtgridAdmin.Rows[e.RowIndex].Cells["Username"].Value).ToString();
            }
        }
    }
}
