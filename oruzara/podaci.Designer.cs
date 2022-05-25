
namespace oruzara
{
    partial class podaci
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtSifra = new System.Windows.Forms.TextBox();
            this.txtKapacitet = new System.Windows.Forms.TextBox();
            this.txtMetak = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_chg = new System.Windows.Forms.Button();
            this.btn_last = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_prev = new System.Windows.Forms.Button();
            this.btn_frst = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(321, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 0;
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(321, 116);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(100, 23);
            this.txtIme.TabIndex = 1;
            // 
            // txtSifra
            // 
            this.txtSifra.Location = new System.Drawing.Point(321, 169);
            this.txtSifra.Name = "txtSifra";
            this.txtSifra.Size = new System.Drawing.Size(100, 23);
            this.txtSifra.TabIndex = 2;
            // 
            // txtKapacitet
            // 
            this.txtKapacitet.Location = new System.Drawing.Point(321, 221);
            this.txtKapacitet.Name = "txtKapacitet";
            this.txtKapacitet.Size = new System.Drawing.Size(100, 23);
            this.txtKapacitet.TabIndex = 3;
            // 
            // txtMetak
            // 
            this.txtMetak.Location = new System.Drawing.Point(321, 271);
            this.txtMetak.Name = "txtMetak";
            this.txtMetak.Size = new System.Drawing.Size(100, 23);
            this.txtMetak.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(262, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(262, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(262, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Sifra";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(262, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Kapacitet";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(246, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Vrsta metka";
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(434, 364);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(94, 29);
            this.btn_del.TabIndex = 21;
            this.btn_del.Text = "Delete";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_chg
            // 
            this.btn_chg.Location = new System.Drawing.Point(334, 364);
            this.btn_chg.Name = "btn_chg";
            this.btn_chg.Size = new System.Drawing.Size(94, 29);
            this.btn_chg.TabIndex = 22;
            this.btn_chg.Text = "Change";
            this.btn_chg.UseVisualStyleBackColor = true;
            this.btn_chg.Click += new System.EventHandler(this.btn_chg_Click);
            // 
            // btn_last
            // 
            this.btn_last.Location = new System.Drawing.Point(487, 329);
            this.btn_last.Name = "btn_last";
            this.btn_last.Size = new System.Drawing.Size(94, 29);
            this.btn_last.TabIndex = 23;
            this.btn_last.Text = ">>";
            this.btn_last.UseVisualStyleBackColor = true;
            this.btn_last.Click += new System.EventHandler(this.btn_last_Click_1);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(232, 364);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(94, 29);
            this.btn_add.TabIndex = 24;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click_1);
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(387, 329);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(94, 29);
            this.btn_next.TabIndex = 25;
            this.btn_next.Text = ">";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click_1);
            // 
            // btn_prev
            // 
            this.btn_prev.Location = new System.Drawing.Point(285, 329);
            this.btn_prev.Name = "btn_prev";
            this.btn_prev.Size = new System.Drawing.Size(94, 29);
            this.btn_prev.TabIndex = 26;
            this.btn_prev.Text = "<";
            this.btn_prev.UseVisualStyleBackColor = true;
            this.btn_prev.Click += new System.EventHandler(this.btn_prev_Click_1);
            // 
            // btn_frst
            // 
            this.btn_frst.Location = new System.Drawing.Point(185, 329);
            this.btn_frst.Name = "btn_frst";
            this.btn_frst.Size = new System.Drawing.Size(94, 29);
            this.btn_frst.TabIndex = 27;
            this.btn_frst.Text = "<<";
            this.btn_frst.UseVisualStyleBackColor = true;
            this.btn_frst.Click += new System.EventHandler(this.btn_frst_Click);
            // 
            // podaci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_chg);
            this.Controls.Add(this.btn_last);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_prev);
            this.Controls.Add(this.btn_frst);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMetak);
            this.Controls.Add(this.txtKapacitet);
            this.Controls.Add(this.txtSifra);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.textBox1);
            this.Name = "podaci";
            this.Text = "podaci";
            this.Load += new System.EventHandler(this.podaci_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtSifra;
        private System.Windows.Forms.TextBox txtKapacitet;
        private System.Windows.Forms.TextBox txtMetak;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_chg;
        private System.Windows.Forms.Button btn_last;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_prev;
        private System.Windows.Forms.Button btn_frst;
    }
}