namespace cvekŠpraljaJakovFiltriranjeISpremanje
{
    partial class Form4
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
            this.btnUcitajDok = new System.Windows.Forms.Button();
            this.btnFiltriraj1 = new System.Windows.Forms.Button();
            this.btnOdustani1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnUcitajDok
            // 
            this.btnUcitajDok.Location = new System.Drawing.Point(12, 12);
            this.btnUcitajDok.Name = "btnUcitajDok";
            this.btnUcitajDok.Size = new System.Drawing.Size(139, 34);
            this.btnUcitajDok.TabIndex = 0;
            this.btnUcitajDok.Text = "Učitaj dokument";
            this.btnUcitajDok.UseVisualStyleBackColor = true;
            this.btnUcitajDok.Click += new System.EventHandler(this.btnUcitajDok_Click);
            // 
            // btnFiltriraj1
            // 
            this.btnFiltriraj1.Location = new System.Drawing.Point(157, 12);
            this.btnFiltriraj1.Name = "btnFiltriraj1";
            this.btnFiltriraj1.Size = new System.Drawing.Size(139, 34);
            this.btnFiltriraj1.TabIndex = 1;
            this.btnFiltriraj1.Text = "Filtriraj";
            this.btnFiltriraj1.UseVisualStyleBackColor = true;
            this.btnFiltriraj1.Click += new System.EventHandler(this.btnFiltriraj1_Click);
            // 
            // btnOdustani1
            // 
            this.btnOdustani1.Location = new System.Drawing.Point(302, 12);
            this.btnOdustani1.Name = "btnOdustani1";
            this.btnOdustani1.Size = new System.Drawing.Size(139, 34);
            this.btnOdustani1.TabIndex = 2;
            this.btnOdustani1.Text = "Odustani";
            this.btnOdustani1.UseVisualStyleBackColor = true;
            this.btnOdustani1.Click += new System.EventHandler(this.btnOdustani1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 54);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(429, 485);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 551);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnOdustani1);
            this.Controls.Add(this.btnFiltriraj1);
            this.Controls.Add(this.btnUcitajDok);
            this.Name = "Form4";
            this.Text = "Pregleda_podataka";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUcitajDok;
        private System.Windows.Forms.Button btnFiltriraj1;
        private System.Windows.Forms.Button btnOdustani1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}