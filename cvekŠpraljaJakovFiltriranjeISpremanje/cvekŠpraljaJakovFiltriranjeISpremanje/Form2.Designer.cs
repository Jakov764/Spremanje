﻿namespace cvekŠpraljaJakovFiltriranjeISpremanje
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnZavrsi = new System.Windows.Forms.Button();
            this.btnUnos1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime";
            // 
            // txtIme
            // 
            this.txtIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtIme.Location = new System.Drawing.Point(13, 41);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(284, 26);
            this.txtIme.TabIndex = 1;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPrezime.Location = new System.Drawing.Point(13, 103);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(284, 26);
            this.txtPrezime.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prezime";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtEmail.Location = new System.Drawing.Point(13, 166);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(284, 26);
            this.txtEmail.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(12, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "E-mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(12, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Razred";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1a",
            "1b",
            "1c",
            "1d",
            "2a",
            "2b",
            "2c",
            "2d",
            "3a",
            "3b",
            "3c",
            "3d",
            "4a",
            "4b",
            "4c",
            "4d"});
            this.comboBox1.Location = new System.Drawing.Point(13, 228);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(284, 28);
            this.comboBox1.TabIndex = 7;
            // 
            // btnZavrsi
            // 
            this.btnZavrsi.Location = new System.Drawing.Point(13, 336);
            this.btnZavrsi.Name = "btnZavrsi";
            this.btnZavrsi.Size = new System.Drawing.Size(284, 47);
            this.btnZavrsi.TabIndex = 9;
            this.btnZavrsi.Text = "Završi";
            this.btnZavrsi.UseVisualStyleBackColor = true;
            this.btnZavrsi.Click += new System.EventHandler(this.btnZavrsi_Click);
            // 
            // btnUnos1
            // 
            this.btnUnos1.Location = new System.Drawing.Point(13, 283);
            this.btnUnos1.Name = "btnUnos1";
            this.btnUnos1.Size = new System.Drawing.Size(284, 47);
            this.btnUnos1.TabIndex = 8;
            this.btnUnos1.Text = "Unos";
            this.btnUnos1.UseVisualStyleBackColor = true;
            this.btnUnos1.Click += new System.EventHandler(this.btnUnos1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 401);
            this.Controls.Add(this.btnZavrsi);
            this.Controls.Add(this.btnUnos1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Unos_Podataka";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnZavrsi;
        private System.Windows.Forms.Button btnUnos1;
    }
}