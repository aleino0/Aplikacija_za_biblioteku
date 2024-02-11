using Aplikacija_za_biblioteku;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Aplikacija_za_biblioteku
{
    public partial class FormPodaci : Form
    {
        List<Knjiga> listKnj = new List<Knjiga>();
        List<Korisnik> listKor = new List<Korisnik>();
        List<Evidencija> listEvi = new List<Evidencija>();
        public FormPodaci()
        {
            InitializeComponent();
            //Finds the directory, which is located at @MainUserDisk://Users//@CurrentUserNamer//AppData//Local
            string mainFile = @"%LOCALAPPDATA%\AplikacijaZaBiblioteku";
            mainFile = Environment.ExpandEnvironmentVariables(mainFile);
            string XMLknjiga = mainFile + "\\Knjige.xml";
            //Loads the xml and saves it as object which is stored in a list
            try
            {
                using (StreamReader reader = new StreamReader(XMLknjiga))
                {
                    XElement newXML = XElement.Load(reader);
                    foreach (XElement element in newXML.Elements())
                    {
                        Knjiga knj = new Knjiga(element.Attribute("ID").Value, element.Attribute("Author").Value, element.Attribute("Naslov").Value, element.Attribute("Izdavac").Value);
                        cBoxKnjiga.Items.Add(knj.Knjiga_ID + "-" + knj.Naslov);
                        listKnj.Add(knj);
                    }
                }
            }
            catch
            {
                //XML file is empty/has no <root>
            }
            string XMLKorisnik = mainFile + "\\Korisnike.xml";
            //Loads the xml and saves it as object which is stored in a list
            try
            {
                using (StreamReader reader = new StreamReader(XMLKorisnik))
                {
                    XElement newXML = XElement.Load(reader);
                    foreach (XElement element in newXML.Elements())
                    {
                        Korisnik kor = new Korisnik(element.Attribute("ID").Value, element.Attribute("Ime").Value, element.Attribute("Prezime").Value, element.Attribute("Email").Value, element.Attribute("Adresa").Value, Convert.ToInt64(element.Attribute("BrojTelefona").Value));
                        cBoxKorisnik.Items.Add(kor.Korisnik_ID + "-" + kor.Ime + " " + kor.Prezime);
                        listKor.Add(kor);
                    }
                }
            }
            catch
            {
                //XML file is empty/has no <root>
            }
            string XMLEvidencija = mainFile + "\\Evidencija.xml";
            //Loads the xml and saves it as object which is stored in a list
            try
            {
                using (StreamReader reader = new StreamReader(XMLEvidencija))
                {
                    XElement newXML = XElement.Load(reader);
                    foreach (XElement element in newXML.Elements())
                    {
                        Evidencija kor = new Evidencija(element.Attribute("KorisnikID").Value, element.Attribute("KnjigaID").Value, Convert.ToDateTime(element.Attribute("DatumPodizanja").Value));
                        if (element.Attribute("DatumVracanja").Value != "0001-01-01T00:00:00")
                        {
                            kor.DatumVrac = Convert.ToDateTime(element.Attribute("DatumVracanja").Value);
                        }
                        listEvi.Add(kor);
                    }
                }
            }
            catch
            {
                //XML file is empty/has no <root>
            }
            this.BackgroundImageLayout = ImageLayout.Zoom;
        }

       

        private void btnUnesi_Click(object sender, EventArgs e)
        {
            try
            {
                Evidencija knj = new Evidencija(cBoxKorisnik.Text.Substring(0, cBoxKorisnik.Text.IndexOf('-')), cBoxKnjiga.Text.Substring(0, cBoxKnjiga.Text.IndexOf('-')), dateTimePicker1.Value);
                listEvi.Add(knj); //Adds the new book object to the book list.
                                  //Converts all book object into an XDocument
                XDocument knjXML = new XDocument(new XElement("Evidencije",
                        from xml in listEvi
                        select new XElement("Evidencija",
                            new XAttribute("KorisnikID", xml.Korisnik_ID),
                            new XAttribute("KnjigaID", xml.Knjiga_ID),
                            new XAttribute("DatumPodizanja", xml.DatumPos),
                            new XAttribute("DatumVracanja", xml.DatumVrac))));
                //Finds the directory, which is located at @MainUserDisk://Users//@CurrentUserNamer//AppData//Local
                string mainFile = @"%LOCALAPPDATA%\AplikacijaZaBiblioteku";
                mainFile = Environment.ExpandEnvironmentVariables(mainFile);
                string fileStream = mainFile + "\\Evidencija.xml";
                //Deletes the xml file and creates the newly update one.
                File.Delete(fileStream); //TODO: convert the old file to old back-up file
                File.AppendAllText(fileStream, knjXML.ToString());

                MessageBox.Show("Knjiga je uspješno spremljena!", "Uspješno spremljena", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception n)
            {
                MessageBox.Show("Greška\r\n" + n, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            cBoxKnjiga.Text = null;
            cBoxKorisnik.Text = null;
            dateTimePicker1.Value = DateTime.Now;
            cBoxKorisnik.Focus();
        }
    }
}
