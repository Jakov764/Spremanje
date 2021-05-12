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
using System.IO;

namespace cvekŠpraljaJakovFiltriranjeISpremanje
{
    public partial class Form2 : Form
    {

        List<Ucenik> listUcenik = new List<Ucenik>();

        public Form2()
        {
            InitializeComponent();
        }


        private void btnUnos1_Click(object sender, EventArgs e)
        {
            if(txtIme.Text.Length == 0 || txtPrezime.Text.Length == 0 || txtEmail.Text.Length == 0 || comboBox1.Text.Length == 0)
            {
                MessageBox.Show("Niste ispunili svako polje. Molimo ispunite sva polja.");
                return;
            }

            Ucenik ucenik = new Ucenik(txtIme.Text, txtPrezime.Text, txtEmail.Text, comboBox1.Text);

            listUcenik.Add(ucenik);

            txtIme.Text = "";
            txtPrezime.Text = "";
            txtEmail.Text = "";
            comboBox1.Text = "";
        }

        private void btnZavrsi_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(@"C:\Documents\xmlDocument1"))
            {
                Directory.CreateDirectory(@"C:\Documents\xmlDocument1");
            }

            var documentXmlUcenici = new XDocument(new XElement("listUcenik",
                from Ucenik in listUcenik select new XElement("Ucenik",
                new XAttribute("Ime", Ucenik.Ime),
                new XAttribute("Prezime", Ucenik.Prezime),
                new XAttribute("EmailAdresa", Ucenik.Email),
                new XAttribute("Razred", Ucenik.Razred)
                )));

            documentXmlUcenici.Save("C:/Documents/xmldocument1/Ucenici.xml");

            Form1 f1 = new Form1();
            this.Hide();
            DialogResult r = f1.ShowDialog();
            this.Close();
        }
    }
}
