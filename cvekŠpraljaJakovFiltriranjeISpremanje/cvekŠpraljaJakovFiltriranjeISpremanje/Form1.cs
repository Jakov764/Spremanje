using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cvekŠpraljaJakovFiltriranjeISpremanje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnUnos_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            this.Hide();
            DialogResult r = f2.ShowDialog();
            this.Close();
        }

        private void btnPrikaz_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            this.Close();
            DialogResult r = f4.ShowDialog();
            this.Close();
        }
    }
}
