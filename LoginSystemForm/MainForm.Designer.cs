namespace EFCore_NoteBook
{
    partial class MainForm
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
            label1 = new Label();
            lstbxMynotes = new ListBox();
            txtTitle = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtContent = new TextBox();
            lnklblChange = new LinkLabel();
            btnNew = new Button();
            btnDelete = new Button();
            btnSave = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 50);
            label1.Name = "label1";
            label1.Size = new Size(128, 39);
            label1.TabIndex = 0;
            label1.Text = "Mynotes";
            // 
            // lstbxMynotes
            // 
            lstbxMynotes.BackColor = Color.SkyBlue;
            lstbxMynotes.ForeColor = Color.White;
            lstbxMynotes.FormattingEnabled = true;
            lstbxMynotes.ItemHeight = 39;
            lstbxMynotes.Location = new Point(50, 125);
            lstbxMynotes.Name = "lstbxMynotes";
            lstbxMynotes.ScrollAlwaysVisible = true;
            lstbxMynotes.Size = new Size(300, 550);
            lstbxMynotes.TabIndex = 1;
            lstbxMynotes.SelectedIndexChanged += lstbxMynotes_SelectedIndexChanged;
            // 
            // txtTitle
            // 
            txtTitle.BackColor = Color.SkyBlue;
            txtTitle.ForeColor = Color.White;
            txtTitle.Location = new Point(425, 125);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(500, 47);
            txtTitle.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(425, 50);
            label2.Name = "label2";
            label2.Size = new Size(79, 39);
            label2.TabIndex = 3;
            label2.Text = "Title";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(425, 200);
            label3.Name = "label3";
            label3.Size = new Size(120, 39);
            label3.TabIndex = 4;
            label3.Text = "Content";
            // 
            // txtContent
            // 
            txtContent.BackColor = Color.SkyBlue;
            txtContent.ForeColor = Color.White;
            txtContent.Location = new Point(425, 275);
            txtContent.Multiline = true;
            txtContent.Name = "txtContent";
            txtContent.Size = new Size(500, 400);
            txtContent.TabIndex = 3;
            // 
            // lnklblChange
            // 
            lnklblChange.AutoSize = true;
            lnklblChange.Font = new Font("Comic Sans MS", 19F, FontStyle.Regular, GraphicsUnit.Point);
            lnklblChange.LinkColor = Color.White;
            lnklblChange.Location = new Point(40, 720);
            lnklblChange.Margin = new Padding(4, 0, 4, 0);
            lnklblChange.Name = "lnklblChange";
            lnklblChange.Size = new Size(321, 53);
            lnklblChange.TabIndex = 4;
            lnklblChange.TabStop = true;
            lnklblChange.Text = "Password Change";
            lnklblChange.LinkClicked += lnklblChange_LinkClicked;
            // 
            // btnNew
            // 
            btnNew.BackColor = Color.SkyBlue;
            btnNew.ForeColor = Color.White;
            btnNew.Location = new Point(420, 700);
            btnNew.Margin = new Padding(4, 3, 4, 3);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(165, 100);
            btnNew.TabIndex = 5;
            btnNew.Text = "New Note";
            btnNew.UseVisualStyleBackColor = false;
            btnNew.Click += btnNew_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.SkyBlue;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(593, 700);
            btnDelete.Margin = new Padding(4, 3, 4, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(165, 100);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Note Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.SkyBlue;
            btnSave.ForeColor = Color.LightCoral;
            btnSave.Location = new Point(766, 700);
            btnSave.Margin = new Padding(4, 3, 4, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(165, 100);
            btnSave.TabIndex = 0;
            btnSave.Text = "Note Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // MainForm
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(17F, 39F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(978, 844);
            Controls.Add(btnSave);
            Controls.Add(btnDelete);
            Controls.Add(btnNew);
            Controls.Add(lnklblChange);
            Controls.Add(txtContent);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtTitle);
            Controls.Add(lstbxMynotes);
            Controls.Add(label1);
            Font = new Font("Comic Sans MS", 14F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.White;
            Margin = new Padding(5);
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main Form";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstbxMynotes;
        private TextBox txtTitle;
        private Label label2;
        private Label label3;
        private TextBox txtContent;
        private LinkLabel lnklblChange;
        private Button btnNew;
        private Button btnDelete;
        private Button btnSave;
    }
}