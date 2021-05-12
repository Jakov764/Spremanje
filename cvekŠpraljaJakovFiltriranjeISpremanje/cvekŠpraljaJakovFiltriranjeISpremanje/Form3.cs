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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnFiltriraj_Click(object sender, EventArgs e)
        {
            var listUcenik = new XDocument();
            if (txtIme.Text.Length == 0 && txtPrezime.Text.Length == 0 && txtEmail.Text.Length == 0 && comboBox1.Text.Length == 0)
            {
                listUcenik = new XDocument(new XElement("listUcenik", from ucenik in XElement.Load("C:/Documents/xmlDocument1/Ucenici.xml").Elements("Ucenik") select ucenik));
            }
            else
            {
                listUcenik = new XDocument(new XElement("listUcenik", from ucenik in XElement.Load("C:/Documents/xmlDocument1/Ucenici.xml").Elements("Ucenik")
                                                                      where (txtIme.Text.Length != 0 && ucenik.Attribute("Ime").Value == txtIme.Text) ||
                                                                      (txtPrezime.Text.Length != 0 && ucenik.Attribute("Prezime").Value == txtPrezime.Text) ||
                                                                      (txtEmail.Text.Length != 0 && ucenik.Attribute("Email").Value == txtEmail.Text) ||
                                                                      (comboBox1.Text.Length != 0 && ucenik.Attribute("Razred").Value == comboBox1.Text)
                                                                      select ucenik));
            }

            listUcenik.Save("C:/Documents/xmlDocument1/FiltriraniUcenici.xml");
            this.Close();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            var listUcenik = new XDocument(new XElement("listUcenik", from ucenik in XElement.Load("C:/Documents/xmlDocument1/Ucenici.xml").Elements("Ucenik") select ucenik));
            listUcenik.Save("C:/Documents/xmlDocument1/FiltriraniUcenici.xml");
            this.Close();
        }
    }
}
