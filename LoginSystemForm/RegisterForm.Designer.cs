namespace LoginSystem
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            pctrbxExit = new PictureBox();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnRegister = new Button();
            txtPasswordConfirm = new TextBox();
            label3 = new Label();
            checkbxShowPass = new CheckBox();
            pctrbxAlert = new PictureBox();
            timer = new System.Windows.Forms.Timer(components);
            lblPassMatch = new Label();
            label4 = new Label();
            txtSurname = new TextBox();
            label5 = new Label();
            txtName = new TextBox();
            panel1 = new Panel();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pctrbxExit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctrbxAlert).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pctrbxExit
            // 
            pctrbxExit.Image = (Image)resources.GetObject("pctrbxExit.Image");
            pctrbxExit.Location = new Point(652, 0);
            pctrbxExit.Name = "pctrbxExit";
            pctrbxExit.Size = new Size(148, 113);
            pctrbxExit.SizeMode = PictureBoxSizeMode.StretchImage;
            pctrbxExit.TabIndex = 0;
            pctrbxExit.TabStop = false;
            pctrbxExit.Click += pctrbxExit_Click;
            pctrbxExit.MouseLeave += pctrbxExit_MouseLeave;
            pctrbxExit.MouseHover += pctrbxExit_MouseHover;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.SkyBlue;
            txtPassword.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.ForeColor = Color.White;
            txtPassword.Location = new Point(350, 425);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(300, 41);
            txtPassword.TabIndex = 4;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.SkyBlue;
            txtUsername.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.ForeColor = Color.White;
            txtUsername.Location = new Point(350, 350);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(300, 41);
            txtUsername.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.SkyBlue;
            label2.ForeColor = Color.White;
            label2.Location = new Point(50, 423);
            label2.Name = "label2";
            label2.Size = new Size(138, 39);
            label2.TabIndex = 9;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.SkyBlue;
            label1.ForeColor = Color.White;
            label1.Location = new Point(50, 348);
            label1.Name = "label1";
            label1.Size = new Size(162, 39);
            label1.TabIndex = 8;
            label1.Text = "User Name";
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.SkyBlue;
            btnRegister.ForeColor = Color.LightCoral;
            btnRegister.Location = new Point(45, 625);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(610, 100);
            btnRegister.TabIndex = 0;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // txtPasswordConfirm
            // 
            txtPasswordConfirm.BackColor = Color.SkyBlue;
            txtPasswordConfirm.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPasswordConfirm.ForeColor = Color.White;
            txtPasswordConfirm.Location = new Point(350, 500);
            txtPasswordConfirm.Name = "txtPasswordConfirm";
            txtPasswordConfirm.Size = new Size(300, 41);
            txtPasswordConfirm.TabIndex = 5;
            txtPasswordConfirm.TextChanged += txtConfirmPass_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.SkyBlue;
            label3.ForeColor = Color.White;
            label3.Location = new Point(50, 498);
            label3.Name = "label3";
            label3.Size = new Size(250, 39);
            label3.TabIndex = 12;
            label3.Text = "Password Confirm";
            // 
            // checkbxShowPass
            // 
            checkbxShowPass.AutoSize = true;
            checkbxShowPass.ForeColor = Color.White;
            checkbxShowPass.Location = new Point(350, 550);
            checkbxShowPass.Name = "checkbxShowPass";
            checkbxShowPass.Size = new Size(241, 43);
            checkbxShowPass.TabIndex = 6;
            checkbxShowPass.Text = "Show Password";
            checkbxShowPass.UseVisualStyleBackColor = true;
            checkbxShowPass.CheckedChanged += checkbxShowPass_CheckedChanged;
            // 
            // pctrbxAlert
            // 
            pctrbxAlert.Image = (Image)resources.GetObject("pctrbxAlert.Image");
            pctrbxAlert.Location = new Point(657, 500);
            pctrbxAlert.Name = "pctrbxAlert";
            pctrbxAlert.Size = new Size(50, 41);
            pctrbxAlert.SizeMode = PictureBoxSizeMode.StretchImage;
            pctrbxAlert.TabIndex = 15;
            pctrbxAlert.TabStop = false;
            pctrbxAlert.Visible = false;
            // 
            // timer
            // 
            timer.Tick += timer_Tick;
            // 
            // lblPassMatch
            // 
            lblPassMatch.AutoSize = true;
            lblPassMatch.BackColor = Color.SkyBlue;
            lblPassMatch.Font = new Font("Comic Sans MS", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblPassMatch.ForeColor = Color.White;
            lblPassMatch.Location = new Point(657, 432);
            lblPassMatch.Name = "lblPassMatch";
            lblPassMatch.Size = new Size(124, 28);
            lblPassMatch.TabIndex = 16;
            lblPassMatch.Text = "Don't match";
            lblPassMatch.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.SkyBlue;
            label4.ForeColor = Color.White;
            label4.Location = new Point(50, 273);
            label4.Name = "label4";
            label4.Size = new Size(131, 39);
            label4.TabIndex = 8;
            label4.Text = "Surname";
            // 
            // txtSurname
            // 
            txtSurname.BackColor = Color.SkyBlue;
            txtSurname.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSurname.ForeColor = Color.White;
            txtSurname.Location = new Point(350, 275);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(300, 41);
            txtSurname.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.SkyBlue;
            label5.ForeColor = Color.White;
            label5.Location = new Point(50, 198);
            label5.Name = "label5";
            label5.Size = new Size(90, 39);
            label5.TabIndex = 8;
            label5.Text = "Name";
            // 
            // txtName
            // 
            txtName.BackColor = Color.SkyBlue;
            txtName.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.ForeColor = Color.White;
            txtName.Location = new Point(350, 200);
            txtName.Name = "txtName";
            txtName.Size = new Size(300, 41);
            txtName.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(label6);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(653, 113);
            panel1.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe Script", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(40, -4);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(591, 114);
            label6.TabIndex = 8;
            label6.Text = "Sign Up Panel";
            // 
            // RegisterForm
            // 
            AcceptButton = btnRegister;
            AutoScaleDimensions = new SizeF(17F, 39F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(800, 800);
            Controls.Add(panel1);
            Controls.Add(lblPassMatch);
            Controls.Add(pctrbxAlert);
            Controls.Add(checkbxShowPass);
            Controls.Add(txtPasswordConfirm);
            Controls.Add(label3);
            Controls.Add(txtPassword);
            Controls.Add(txtName);
            Controls.Add(txtSurname);
            Controls.Add(label5);
            Controls.Add(txtUsername);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnRegister);
            Controls.Add(pctrbxExit);
            Font = new Font("Comic Sans MS", 14F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5);
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterForm";
            Load += RegisterSystemForm_Load;
            ((System.ComponentModel.ISupportInitialize)pctrbxExit).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctrbxAlert).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pctrbxExit;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Label label2;
        private Label label1;
        private Button btnRegister;
        private TextBox txtPasswordConfirm;
        private Label label3;
        private CheckBox checkbxShowPass;
        private PictureBox pctrbxAlert;
        private System.Windows.Forms.Timer timer;
        private Label lblPassMatch;
        private Label label4;
        private TextBox txtSurname;
        private Label label5;
        private TextBox txtName;
        private Panel panel1;
        private Label label6;
    }
}