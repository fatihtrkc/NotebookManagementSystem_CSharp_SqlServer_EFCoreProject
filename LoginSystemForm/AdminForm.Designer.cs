namespace EFCore_NoteBook
{
    partial class AdminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            dtgridAdmin = new DataGridView();
            btnActivePassive = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgridAdmin).BeginInit();
            SuspendLayout();
            // 
            // dtgridAdmin
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Comic Sans MS", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.SkyBlue;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dtgridAdmin.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dtgridAdmin.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgridAdmin.BackgroundColor = Color.SkyBlue;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.SkyBlue;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dtgridAdmin.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dtgridAdmin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Comic Sans MS", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dtgridAdmin.DefaultCellStyle = dataGridViewCellStyle3;
            dtgridAdmin.GridColor = Color.SkyBlue;
            dtgridAdmin.Location = new Point(0, 100);
            dtgridAdmin.MultiSelect = false;
            dtgridAdmin.Name = "dtgridAdmin";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Comic Sans MS", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.SkyBlue;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dtgridAdmin.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dtgridAdmin.RowHeadersWidth = 62;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Comic Sans MS", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.SkyBlue;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dtgridAdmin.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dtgridAdmin.RowTemplate.Height = 33;
            dtgridAdmin.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgridAdmin.Size = new Size(1178, 644);
            dtgridAdmin.TabIndex = 0;
            dtgridAdmin.CellClick += dtgridAdmin_CellClick;
            // 
            // btnActivePassive
            // 
            btnActivePassive.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnActivePassive.BackColor = Color.SkyBlue;
            btnActivePassive.Font = new Font("Segoe Print", 28F, FontStyle.Regular, GraphicsUnit.Point);
            btnActivePassive.ForeColor = Color.LightCoral;
            btnActivePassive.Location = new Point(0, 0);
            btnActivePassive.Margin = new Padding(4, 3, 4, 3);
            btnActivePassive.Name = "btnActivePassive";
            btnActivePassive.Size = new Size(1178, 100);
            btnActivePassive.TabIndex = 0;
            btnActivePassive.Text = "Active  /  Passive";
            btnActivePassive.UseVisualStyleBackColor = false;
            btnActivePassive.Click += btnActivePassive_Click;
            // 
            // AdminForm
            // 
            AcceptButton = btnActivePassive;
            AutoScaleDimensions = new SizeF(17F, 39F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(1178, 744);
            Controls.Add(btnActivePassive);
            Controls.Add(dtgridAdmin);
            Font = new Font("Comic Sans MS", 14F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.White;
            Margin = new Padding(5);
            Name = "AdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminForm";
            Load += AdminForm_Load;
            ((System.ComponentModel.ISupportInitialize)dtgridAdmin).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtgridAdmin;
        private Button btnActivePassive;
    }
}