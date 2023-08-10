namespace EFCore_NoteBook
{
    partial class PasswordForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordForm));
            label6 = new Label();
            lblPassMatch = new Label();
            timer = new System.Windows.Forms.Timer(components);
            panel1 = new Panel();
            pctrbxAlert = new PictureBox();
            checkbxShowPass = new CheckBox();
            txtPasswordNewConfirm = new TextBox();
            label3 = new Label();
            txtPasswordNew = new TextBox();
            txtPasswordOld = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnPasswordUpdt = new Button();
            pctrbxExit = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pctrbxAlert).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctrbxExit).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe Script", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(40, 10);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(599, 95);
            label6.TabIndex = 8;
            label6.Text = "Password Change";
            // 
            // lblPassMatch
            // 
            lblPassMatch.AutoSize = true;
            lblPassMatch.BackColor = Color.SkyBlue;
            lblPassMatch.Font = new Font("Comic Sans MS", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblPassMatch.ForeColor = Color.White;
            lblPassMatch.Location = new Point(657, 284);
            lblPassMatch.Name = "lblPassMatch";
            lblPassMatch.Size = new Size(124, 28);
            lblPassMatch.TabIndex = 32;
            lblPassMatch.Text = "Don't match";
            lblPassMatch.Visible = false;
            // 
            // timer
            // 
            timer.Tick += timer_Tick;
            // 
            // panel1
            // 
            panel1.Controls.Add(label6);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(653, 113);
            panel1.TabIndex = 33;
            // 
            // pctrbxAlert
            // 
            pctrbxAlert.Image = (Image)resources.GetObject("pctrbxAlert.Image");
            pctrbxAlert.Location = new Point(657, 352);
            pctrbxAlert.Name = "pctrbxAlert";
            pctrbxAlert.Size = new Size(50, 41);
            pctrbxAlert.SizeMode = PictureBoxSizeMode.StretchImage;
            pctrbxAlert.TabIndex = 31;
            pctrbxAlert.TabStop = false;
            pctrbxAlert.Visible = false;
            // 
            // checkbxShowPass
            // 
            checkbxShowPass.AutoSize = true;
            checkbxShowPass.ForeColor = Color.White;
            checkbxShowPass.Location = new Point(350, 402);
            checkbxShowPass.Name = "checkbxShowPass";
            checkbxShowPass.Size = new Size(241, 43);
            checkbxShowPass.TabIndex = 4;
            checkbxShowPass.Text = "Show Password";
            checkbxShowPass.UseVisualStyleBackColor = true;
            checkbxShowPass.CheckedChanged += checkbxShowPass_CheckedChanged;
            // 
            // txtPasswordNewConfirm
            // 
            txtPasswordNewConfirm.BackColor = Color.SkyBlue;
            txtPasswordNewConfirm.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPasswordNewConfirm.ForeColor = Color.White;
            txtPasswordNewConfirm.Location = new Point(350, 352);
            txtPasswordNewConfirm.Name = "txtPasswordNewConfirm";
            txtPasswordNewConfirm.Size = new Size(300, 41);
            txtPasswordNewConfirm.TabIndex = 3;
            txtPasswordNewConfirm.TextChanged += txtPasswordNewConfirm_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.SkyBlue;
            label3.ForeColor = Color.White;
            label3.Location = new Point(50, 350);
            label3.Name = "label3";
            label3.Size = new Size(250, 39);
            label3.TabIndex = 28;
            label3.Text = "Password Confirm";
            // 
            // txtPasswordNew
            // 
            txtPasswordNew.BackColor = Color.SkyBlue;
            txtPasswordNew.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPasswordNew.ForeColor = Color.White;
            txtPasswordNew.Location = new Point(350, 277);
            txtPasswordNew.Name = "txtPasswordNew";
            txtPasswordNew.Size = new Size(300, 41);
            txtPasswordNew.TabIndex = 2;
            txtPasswordNew.TextChanged += txtPasswordNew_TextChanged;
            // 
            // txtPasswordOld
            // 
            txtPasswordOld.BackColor = Color.SkyBlue;
            txtPasswordOld.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPasswordOld.ForeColor = Color.White;
            txtPasswordOld.Location = new Point(350, 202);
            txtPasswordOld.Name = "txtPasswordOld";
            txtPasswordOld.Size = new Size(300, 41);
            txtPasswordOld.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.SkyBlue;
            label2.ForeColor = Color.White;
            label2.Location = new Point(50, 275);
            label2.Name = "label2";
            label2.Size = new Size(202, 39);
            label2.TabIndex = 23;
            label2.Text = "New Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.SkyBlue;
            label1.ForeColor = Color.White;
            label1.Location = new Point(50, 200);
            label1.Name = "label1";
            label1.Size = new Size(192, 39);
            label1.TabIndex = 20;
            label1.Text = "Old Password";
            // 
            // btnPasswordUpdt
            // 
            btnPasswordUpdt.BackColor = Color.SkyBlue;
            btnPasswordUpdt.ForeColor = Color.LightCoral;
            btnPasswordUpdt.Location = new Point(45, 475);
            btnPasswordUpdt.Name = "btnPasswordUpdt";
            btnPasswordUpdt.Size = new Size(610, 100);
            btnPasswordUpdt.TabIndex = 0;
            btnPasswordUpdt.Text = "Password Update";
            btnPasswordUpdt.UseVisualStyleBackColor = false;
            btnPasswordUpdt.Click += btnPasswordUpdt_Click;
            // 
            // pctrbxExit
            // 
            pctrbxExit.Image = (Image)resources.GetObject("pctrbxExit.Image");
            pctrbxExit.Location = new Point(652, 0);
            pctrbxExit.Name = "pctrbxExit";
            pctrbxExit.Size = new Size(148, 113);
            pctrbxExit.SizeMode = PictureBoxSizeMode.StretchImage;
            pctrbxExit.TabIndex = 18;
            pctrbxExit.TabStop = false;
            pctrbxExit.Click += pctrbxExit_Click;
            pctrbxExit.MouseLeave += pctrbxExit_MouseLeave;
            pctrbxExit.MouseHover += pctrbxExit_MouseHover;
            // 
            // PasswordForm
            // 
            AcceptButton = btnPasswordUpdt;
            AutoScaleDimensions = new SizeF(17F, 39F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(800, 650);
            Controls.Add(lblPassMatch);
            Controls.Add(panel1);
            Controls.Add(pctrbxAlert);
            Controls.Add(checkbxShowPass);
            Controls.Add(txtPasswordNewConfirm);
            Controls.Add(label3);
            Controls.Add(txtPasswordNew);
            Controls.Add(txtPasswordOld);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnPasswordUpdt);
            Controls.Add(pctrbxExit);
            Font = new Font("Comic Sans MS", 14F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5);
            Name = "PasswordForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PasswordForm";
            Load += PasswordForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pctrbxAlert).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctrbxExit).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Label lblPassMatch;
        private System.Windows.Forms.Timer timer;
        private Panel panel1;
        private PictureBox pctrbxAlert;
        private CheckBox checkbxShowPass;
        private TextBox txtPasswordNewConfirm;
        private Label label3;
        private TextBox txtPasswordNew;
        private TextBox txtPasswordOld;
        private Label label2;
        private Label label1;
        private Button btnPasswordUpdt;
        private PictureBox pctrbxExit;
    }
}