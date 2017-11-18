namespace PasswordManager
{
    partial class MainWindow
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Btn_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.Btn_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.Btn_Generator = new System.Windows.Forms.ToolStripMenuItem();
            this.LB_Display = new System.Windows.Forms.ListBox();
            this.Btn_Crd_Open = new System.Windows.Forms.Button();
            this.Btn_Crd_Add = new System.Windows.Forms.Button();
            this.Btn_Crd_Save = new System.Windows.Forms.Button();
            this.Label_Credentials = new System.Windows.Forms.Label();
            this.RTB_Crd_Comment = new System.Windows.Forms.RichTextBox();
            this.TB_Crd_Username = new System.Windows.Forms.TextBox();
            this.TB_Crd_Password = new System.Windows.Forms.TextBox();
            this.TB_Crd_Email = new System.Windows.Forms.TextBox();
            this.GB_Crd = new System.Windows.Forms.GroupBox();
            this.Label_Crd_Comment = new System.Windows.Forms.Label();
            this.Label_Crd_Email = new System.Windows.Forms.Label();
            this.Label_Crd_Password = new System.Windows.Forms.Label();
            this.Label_Crd_Username = new System.Windows.Forms.Label();
            this.Btn_Crd_Remove = new System.Windows.Forms.Button();
            this.Label_Crd_Name = new System.Windows.Forms.Label();
            this.TB_Crd_Name = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.GB_Crd.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(583, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Btn_Open,
            this.Btn_Save,
            this.Btn_Generator});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // Btn_Open
            // 
            this.Btn_Open.Name = "Btn_Open";
            this.Btn_Open.Size = new System.Drawing.Size(152, 22);
            this.Btn_Open.Text = "Open";
            this.Btn_Open.Click += new System.EventHandler(this.Btn_Open_Click);
            // 
            // Btn_Save
            // 
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(152, 22);
            this.Btn_Save.Text = "Save";
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // Btn_Generator
            // 
            this.Btn_Generator.Name = "Btn_Generator";
            this.Btn_Generator.Size = new System.Drawing.Size(152, 22);
            this.Btn_Generator.Text = "Generator";
            this.Btn_Generator.Click += new System.EventHandler(this.Btn_Generator_Click);
            // 
            // LB_Display
            // 
            this.LB_Display.FormattingEnabled = true;
            this.LB_Display.Location = new System.Drawing.Point(12, 53);
            this.LB_Display.Name = "LB_Display";
            this.LB_Display.Size = new System.Drawing.Size(246, 251);
            this.LB_Display.TabIndex = 2;
            // 
            // Btn_Crd_Open
            // 
            this.Btn_Crd_Open.Location = new System.Drawing.Point(264, 53);
            this.Btn_Crd_Open.Name = "Btn_Crd_Open";
            this.Btn_Crd_Open.Size = new System.Drawing.Size(75, 23);
            this.Btn_Crd_Open.TabIndex = 3;
            this.Btn_Crd_Open.Text = "Open";
            this.Btn_Crd_Open.UseVisualStyleBackColor = true;
            this.Btn_Crd_Open.Click += new System.EventHandler(this.Btn_Crd_Open_Click);
            // 
            // Btn_Crd_Add
            // 
            this.Btn_Crd_Add.Location = new System.Drawing.Point(264, 82);
            this.Btn_Crd_Add.Name = "Btn_Crd_Add";
            this.Btn_Crd_Add.Size = new System.Drawing.Size(75, 23);
            this.Btn_Crd_Add.TabIndex = 4;
            this.Btn_Crd_Add.Text = "Add";
            this.Btn_Crd_Add.UseVisualStyleBackColor = true;
            this.Btn_Crd_Add.Click += new System.EventHandler(this.Btn_Crd_Add_Click);
            // 
            // Btn_Crd_Save
            // 
            this.Btn_Crd_Save.Location = new System.Drawing.Point(264, 140);
            this.Btn_Crd_Save.Name = "Btn_Crd_Save";
            this.Btn_Crd_Save.Size = new System.Drawing.Size(75, 23);
            this.Btn_Crd_Save.TabIndex = 5;
            this.Btn_Crd_Save.Text = "Save";
            this.Btn_Crd_Save.UseVisualStyleBackColor = true;
            this.Btn_Crd_Save.Click += new System.EventHandler(this.Btn_Crd_Save_Click);
            // 
            // Label_Credentials
            // 
            this.Label_Credentials.AutoSize = true;
            this.Label_Credentials.Location = new System.Drawing.Point(12, 37);
            this.Label_Credentials.Name = "Label_Credentials";
            this.Label_Credentials.Size = new System.Drawing.Size(59, 13);
            this.Label_Credentials.TabIndex = 6;
            this.Label_Credentials.Text = "Credentials";
            // 
            // RTB_Crd_Comment
            // 
            this.RTB_Crd_Comment.Location = new System.Drawing.Point(9, 174);
            this.RTB_Crd_Comment.Name = "RTB_Crd_Comment";
            this.RTB_Crd_Comment.Size = new System.Drawing.Size(158, 69);
            this.RTB_Crd_Comment.TabIndex = 7;
            this.RTB_Crd_Comment.Text = "";
            // 
            // TB_Crd_Username
            // 
            this.TB_Crd_Username.Location = new System.Drawing.Point(67, 55);
            this.TB_Crd_Username.Name = "TB_Crd_Username";
            this.TB_Crd_Username.Size = new System.Drawing.Size(100, 20);
            this.TB_Crd_Username.TabIndex = 8;
            // 
            // TB_Crd_Password
            // 
            this.TB_Crd_Password.Location = new System.Drawing.Point(67, 81);
            this.TB_Crd_Password.Name = "TB_Crd_Password";
            this.TB_Crd_Password.Size = new System.Drawing.Size(100, 20);
            this.TB_Crd_Password.TabIndex = 9;
            // 
            // TB_Crd_Email
            // 
            this.TB_Crd_Email.Location = new System.Drawing.Point(67, 107);
            this.TB_Crd_Email.Name = "TB_Crd_Email";
            this.TB_Crd_Email.Size = new System.Drawing.Size(100, 20);
            this.TB_Crd_Email.TabIndex = 10;
            // 
            // GB_Crd
            // 
            this.GB_Crd.Controls.Add(this.TB_Crd_Name);
            this.GB_Crd.Controls.Add(this.Label_Crd_Name);
            this.GB_Crd.Controls.Add(this.Label_Crd_Comment);
            this.GB_Crd.Controls.Add(this.Label_Crd_Email);
            this.GB_Crd.Controls.Add(this.RTB_Crd_Comment);
            this.GB_Crd.Controls.Add(this.TB_Crd_Username);
            this.GB_Crd.Controls.Add(this.Label_Crd_Password);
            this.GB_Crd.Controls.Add(this.TB_Crd_Email);
            this.GB_Crd.Controls.Add(this.Label_Crd_Username);
            this.GB_Crd.Controls.Add(this.TB_Crd_Password);
            this.GB_Crd.Location = new System.Drawing.Point(361, 53);
            this.GB_Crd.Name = "GB_Crd";
            this.GB_Crd.Size = new System.Drawing.Size(210, 249);
            this.GB_Crd.TabIndex = 11;
            this.GB_Crd.TabStop = false;
            this.GB_Crd.Text = "Credential";
            // 
            // Label_Crd_Comment
            // 
            this.Label_Crd_Comment.AutoSize = true;
            this.Label_Crd_Comment.Location = new System.Drawing.Point(6, 158);
            this.Label_Crd_Comment.Name = "Label_Crd_Comment";
            this.Label_Crd_Comment.Size = new System.Drawing.Size(51, 13);
            this.Label_Crd_Comment.TabIndex = 15;
            this.Label_Crd_Comment.Text = "Comment";
            // 
            // Label_Crd_Email
            // 
            this.Label_Crd_Email.AutoSize = true;
            this.Label_Crd_Email.Location = new System.Drawing.Point(29, 110);
            this.Label_Crd_Email.Name = "Label_Crd_Email";
            this.Label_Crd_Email.Size = new System.Drawing.Size(32, 13);
            this.Label_Crd_Email.TabIndex = 14;
            this.Label_Crd_Email.Text = "Email";
            // 
            // Label_Crd_Password
            // 
            this.Label_Crd_Password.AutoSize = true;
            this.Label_Crd_Password.Location = new System.Drawing.Point(8, 84);
            this.Label_Crd_Password.Name = "Label_Crd_Password";
            this.Label_Crd_Password.Size = new System.Drawing.Size(53, 13);
            this.Label_Crd_Password.TabIndex = 13;
            this.Label_Crd_Password.Text = "Password";
            // 
            // Label_Crd_Username
            // 
            this.Label_Crd_Username.AutoSize = true;
            this.Label_Crd_Username.Location = new System.Drawing.Point(6, 58);
            this.Label_Crd_Username.Name = "Label_Crd_Username";
            this.Label_Crd_Username.Size = new System.Drawing.Size(55, 13);
            this.Label_Crd_Username.TabIndex = 12;
            this.Label_Crd_Username.Text = "Username";
            // 
            // Btn_Crd_Remove
            // 
            this.Btn_Crd_Remove.Location = new System.Drawing.Point(264, 111);
            this.Btn_Crd_Remove.Name = "Btn_Crd_Remove";
            this.Btn_Crd_Remove.Size = new System.Drawing.Size(75, 23);
            this.Btn_Crd_Remove.TabIndex = 12;
            this.Btn_Crd_Remove.Text = "Remove";
            this.Btn_Crd_Remove.UseVisualStyleBackColor = true;
            // 
            // Label_Crd_Name
            // 
            this.Label_Crd_Name.AutoSize = true;
            this.Label_Crd_Name.Location = new System.Drawing.Point(26, 32);
            this.Label_Crd_Name.Name = "Label_Crd_Name";
            this.Label_Crd_Name.Size = new System.Drawing.Size(35, 13);
            this.Label_Crd_Name.TabIndex = 16;
            this.Label_Crd_Name.Text = "Name";
            // 
            // TB_Crd_Name
            // 
            this.TB_Crd_Name.Location = new System.Drawing.Point(67, 29);
            this.TB_Crd_Name.Name = "TB_Crd_Name";
            this.TB_Crd_Name.Size = new System.Drawing.Size(100, 20);
            this.TB_Crd_Name.TabIndex = 17;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 314);
            this.Controls.Add(this.Btn_Crd_Remove);
            this.Controls.Add(this.GB_Crd);
            this.Controls.Add(this.Label_Credentials);
            this.Controls.Add(this.Btn_Crd_Save);
            this.Controls.Add(this.Btn_Crd_Add);
            this.Controls.Add(this.Btn_Crd_Open);
            this.Controls.Add(this.LB_Display);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "Password Manager";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.GB_Crd.ResumeLayout(false);
            this.GB_Crd.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Btn_Open;
        private System.Windows.Forms.ToolStripMenuItem Btn_Save;
        private System.Windows.Forms.ToolStripMenuItem Btn_Generator;
        private System.Windows.Forms.ListBox LB_Display;
        private System.Windows.Forms.Button Btn_Crd_Open;
        private System.Windows.Forms.Button Btn_Crd_Add;
        private System.Windows.Forms.Button Btn_Crd_Save;
        private System.Windows.Forms.Label Label_Credentials;
        private System.Windows.Forms.RichTextBox RTB_Crd_Comment;
        private System.Windows.Forms.TextBox TB_Crd_Username;
        private System.Windows.Forms.TextBox TB_Crd_Password;
        private System.Windows.Forms.TextBox TB_Crd_Email;
        private System.Windows.Forms.GroupBox GB_Crd;
        private System.Windows.Forms.Label Label_Crd_Email;
        private System.Windows.Forms.Label Label_Crd_Password;
        private System.Windows.Forms.Label Label_Crd_Username;
        private System.Windows.Forms.Label Label_Crd_Comment;
        private System.Windows.Forms.Button Btn_Crd_Remove;
        private System.Windows.Forms.TextBox TB_Crd_Name;
        private System.Windows.Forms.Label Label_Crd_Name;
    }
}

