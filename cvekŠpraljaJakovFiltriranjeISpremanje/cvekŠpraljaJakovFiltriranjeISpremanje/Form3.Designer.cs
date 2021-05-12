namespace cvekŠpraljaJakovFiltriranjeISpremanje
{
    partial class Form3
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
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnFiltriraj = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(12, 336);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(284, 47);
            this.btnOdustani.TabIndex = 19;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnFiltriraj
            // 
            this.btnFiltriraj.Location = new System.Drawing.Point(12, 283);
            this.btnFiltriraj.Name = "btnFiltriraj";
            this.btnFiltriraj.Size = new System.Drawing.Size(284, 47);
            this.btnFiltriraj.TabIndex = 18;
            this.btnFiltriraj.Text = "Filtriraj";
            this.btnFiltriraj.UseVisualStyleBackColor = true;
            this.btnFiltriraj.Click += new System.EventHandler(this.btnFiltriraj_Click);
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
            this.comboBox1.Location = new System.Drawing.Point(12, 228);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(284, 28);
            this.comboBox1.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(11, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Razred";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtEmail.Location = new System.Drawing.Point(12, 166);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(284, 26);
            this.txtEmail.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(11, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "E-mail";
            // 
            // txtPrezime
            // 
            this.txtPrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPrezime.Location = new System.Drawing.Point(12, 103);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(284, 26);
            this.txtPrezime.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(11, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Prezime";
            // 
            // txtIme
            // 
            this.txtIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtIme.Location = new System.Drawing.Point(12, 41);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(284, 26);
            this.txtIme.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(11, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ime";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 403);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnFiltriraj);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Filtriranje_podataka";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnFiltriraj;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label label1;
    }
}