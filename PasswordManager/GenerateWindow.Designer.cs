namespace PasswordManager
{
    partial class GenerateWindow
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
            this.NUD_PasswordLength = new System.Windows.Forms.NumericUpDown();
            this.CB_SpecialCharacters = new System.Windows.Forms.CheckBox();
            this.CB_Numbers = new System.Windows.Forms.CheckBox();
            this.LB_Passwords = new System.Windows.Forms.ListBox();
            this.Btn_Clear = new System.Windows.Forms.Button();
            this.Btn_Generate = new System.Windows.Forms.Button();
            this.Btn_Copy = new System.Windows.Forms.Button();
            this.LB_CopyConfirmed = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_PasswordLength)).BeginInit();
            this.SuspendLayout();
            // 
            // NUD_PasswordLength
            // 
            this.NUD_PasswordLength.Location = new System.Drawing.Point(175, 59);
            this.NUD_PasswordLength.Name = "NUD_PasswordLength";
            this.NUD_PasswordLength.Size = new System.Drawing.Size(114, 20);
            this.NUD_PasswordLength.TabIndex = 16;
            // 
            // CB_SpecialCharacters
            // 
            this.CB_SpecialCharacters.AutoSize = true;
            this.CB_SpecialCharacters.Location = new System.Drawing.Point(174, 36);
            this.CB_SpecialCharacters.Name = "CB_SpecialCharacters";
            this.CB_SpecialCharacters.Size = new System.Drawing.Size(115, 17);
            this.CB_SpecialCharacters.TabIndex = 15;
            this.CB_SpecialCharacters.Text = "Special Characters";
            this.CB_SpecialCharacters.UseVisualStyleBackColor = true;
            // 
            // CB_Numbers
            // 
            this.CB_Numbers.AutoSize = true;
            this.CB_Numbers.Location = new System.Drawing.Point(175, 13);
            this.CB_Numbers.Name = "CB_Numbers";
            this.CB_Numbers.Size = new System.Drawing.Size(68, 17);
            this.CB_Numbers.TabIndex = 14;
            this.CB_Numbers.Text = "Numbers";
            this.CB_Numbers.UseVisualStyleBackColor = true;
            // 
            // LB_Passwords
            // 
            this.LB_Passwords.FormattingEnabled = true;
            this.LB_Passwords.Location = new System.Drawing.Point(12, 12);
            this.LB_Passwords.Name = "LB_Passwords";
            this.LB_Passwords.Size = new System.Drawing.Size(156, 95);
            this.LB_Passwords.TabIndex = 13;
            // 
            // Btn_Clear
            // 
            this.Btn_Clear.Location = new System.Drawing.Point(93, 114);
            this.Btn_Clear.Name = "Btn_Clear";
            this.Btn_Clear.Size = new System.Drawing.Size(75, 23);
            this.Btn_Clear.TabIndex = 11;
            this.Btn_Clear.Text = "Clear";
            this.Btn_Clear.UseVisualStyleBackColor = true;
            this.Btn_Clear.Click += new System.EventHandler(this.Btn_Clear_Click);
            // 
            // Btn_Generate
            // 
            this.Btn_Generate.Location = new System.Drawing.Point(12, 114);
            this.Btn_Generate.Name = "Btn_Generate";
            this.Btn_Generate.Size = new System.Drawing.Size(75, 23);
            this.Btn_Generate.TabIndex = 10;
            this.Btn_Generate.Text = "Generate";
            this.Btn_Generate.UseVisualStyleBackColor = true;
            this.Btn_Generate.Click += new System.EventHandler(this.Btn_Generate_Click);
            // 
            // Btn_Copy
            // 
            this.Btn_Copy.Location = new System.Drawing.Point(174, 84);
            this.Btn_Copy.Name = "Btn_Copy";
            this.Btn_Copy.Size = new System.Drawing.Size(115, 23);
            this.Btn_Copy.TabIndex = 17;
            this.Btn_Copy.Text = "Copy to Clipboard";
            this.Btn_Copy.UseVisualStyleBackColor = true;
            this.Btn_Copy.Click += new System.EventHandler(this.Btn_Copy_Click);
            // 
            // LB_CopyConfirmed
            // 
            this.LB_CopyConfirmed.AutoSize = true;
            this.LB_CopyConfirmed.Location = new System.Drawing.Point(175, 114);
            this.LB_CopyConfirmed.Name = "LB_CopyConfirmed";
            this.LB_CopyConfirmed.Size = new System.Drawing.Size(0, 13);
            this.LB_CopyConfirmed.TabIndex = 18;
            // 
            // GenerateWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 153);
            this.Controls.Add(this.LB_CopyConfirmed);
            this.Controls.Add(this.Btn_Copy);
            this.Controls.Add(this.NUD_PasswordLength);
            this.Controls.Add(this.CB_SpecialCharacters);
            this.Controls.Add(this.CB_Numbers);
            this.Controls.Add(this.LB_Passwords);
            this.Controls.Add(this.Btn_Clear);
            this.Controls.Add(this.Btn_Generate);
            this.Name = "GenerateWindow";
            this.Text = "GenerateWindow";
            ((System.ComponentModel.ISupportInitialize)(this.NUD_PasswordLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown NUD_PasswordLength;
        private System.Windows.Forms.CheckBox CB_SpecialCharacters;
        private System.Windows.Forms.CheckBox CB_Numbers;
        private System.Windows.Forms.ListBox LB_Passwords;
        private System.Windows.Forms.Button Btn_Clear;
        private System.Windows.Forms.Button Btn_Generate;
        private System.Windows.Forms.Button Btn_Copy;
        private System.Windows.Forms.Label LB_CopyConfirmed;
    }
}