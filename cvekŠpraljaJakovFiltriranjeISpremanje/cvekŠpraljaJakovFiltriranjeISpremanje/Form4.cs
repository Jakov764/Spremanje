using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace cvekŠpraljaJakovFiltriranjeISpremanje
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnUcitajDok_Click(object sender, EventArgs e)
        {
            var listUcenik = from ucenik in XElement.Load("C:/Documents/xmlDocument1/Ucenici.xml").Elements("Ucenik").Attributes() select ucenik;
            richTextBox1.Clear();
            foreach (var item in listUcenik)
            {
                richTextBox1.Text += item.ToString() + "\n";
            }
        }
        private void btnOdustani1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            DialogResult r = f1.ShowDialog();
            this.Close();
        }

        private void btnFiltriraj1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.ShowDialog();
            this.Show();
            var listUcenik = from ucenik in XElement.Load("C:/Documents/xmlDocument1/FiltriraniUcenici.xml").Elements("Ucenik").Attributes() select ucenik;
            richTextBox1.Clear();
            foreach (var item in listUcenik)
            {
                richTextBox1.Text += item.ToString() + "\n";
            }
        }
    }
}
