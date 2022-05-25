
namespace oruzara
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btn_podaci = new System.Windows.Forms.Button();
            this.Skladiste = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(560, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "Oruzarnica";
            // 
            // btn_podaci
            // 
            this.btn_podaci.Location = new System.Drawing.Point(10, 27);
            this.btn_podaci.Name = "btn_podaci";
            this.btn_podaci.Size = new System.Drawing.Size(94, 40);
            this.btn_podaci.TabIndex = 1;
            this.btn_podaci.Text = "Podaci";
            this.btn_podaci.UseVisualStyleBackColor = true;
            this.btn_podaci.Click += new System.EventHandler(this.btn_podaci_Click);
            // 
            // Skladiste
            // 
            this.Skladiste.Location = new System.Drawing.Point(113, 27);
            this.Skladiste.Name = "Skladiste";
            this.Skladiste.Size = new System.Drawing.Size(94, 40);
            this.Skladiste.TabIndex = 2;
            this.Skladiste.Text = "Skladiste";
            this.Skladiste.UseVisualStyleBackColor = true;
            this.Skladiste.Click += new System.EventHandler(this.Skladiste_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Skladiste);
            this.Controls.Add(this.btn_podaci);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_podaci;
        private System.Windows.Forms.Button Skladiste;
    }
}

