﻿
namespace oruzara
{
    partial class login
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
            this.logInButton = new System.Windows.Forms.Button();
            this.lbl_pass = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // logInButton
            // 
            this.logInButton.Location = new System.Drawing.Point(382, 262);
            this.logInButton.Name = "logInButton";
            this.logInButton.Size = new System.Drawing.Size(75, 23);
            this.logInButton.TabIndex = 7;
            this.logInButton.Text = "Uloguj se";
            this.logInButton.UseVisualStyleBackColor = true;
            this.logInButton.Click += new System.EventHandler(this.logInButton_Click);
            // 
            // lbl_pass
            // 
            this.lbl_pass.AutoSize = true;
            this.lbl_pass.Location = new System.Drawing.Point(233, 219);
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(57, 15);
            this.lbl_pass.TabIndex = 5;
            this.lbl_pass.Text = "Password";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(233, 169);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(27, 15);
            this.lbl_name.TabIndex = 6;
            this.lbl_name.Text = "Ime";
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(297, 216);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(270, 23);
            this.txt_pass.TabIndex = 3;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(297, 166);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(270, 23);
            this.txt_name.TabIndex = 4;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.logInButton);
            this.Controls.Add(this.lbl_pass);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_name);
            this.Name = "login";
            this.Text = "login";
            this.Load += new System.EventHandler(this.login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logInButton;
        private System.Windows.Forms.Label lbl_pass;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.TextBox txt_name;
    }
}