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

namespace Aplikacija_za_biblioteku
{
    public partial class UnosKnijga : Form
    {
        //Makes List of book objects
        List<Knjiga> list = new List<Knjiga>();

        public UnosKnijga()
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
                        list.Add(knj);
                    }
                }
            }
            catch
            {
                //XML file is empty/has no <root>
            }
            fAutor.Focus();
            this.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void bntUnesi_Click(object sender, EventArgs e)
        {
            //Creates an random string which is used for the ID, checks all object if another object has the same ID if not saves it to the newly created book object, if it does as starts over for id.
            try
            {
            Rando: Random doRan = new Random();
                string ranID = Convert.ToString(doRan.Next());
                foreach (Knjiga os in list)
                {
                    if (os.Knjiga_ID == ranID)
                    {
                        goto Rando;
                    }
                }
                Knjiga knj = new Knjiga(ranID, fAutor.Text, fNaslov.Text, fIzdavac.Text);
                list.Add(knj); //Adds the new book object to the book list.
                //Converts all book object into an XDocument
                XDocument knjXML = new XDocument(new XElement("Knjige",
                        from xml in list
                        select new XElement("Knjige",
                            new XAttribute("ID", xml.Knjiga_ID),
                            new XAttribute("Author", xml.Author),
                            new XAttribute("Naslov", xml.Naslov),
                            new XAttribute("Izdavac", xml.Izdavac))));
                //Finds the directory, which is located at @MainUserDisk://Users//@CurrentUserNamer//AppData//Local
                string mainFile = @"%LOCALAPPDATA%\AplikacijaZaBiblioteku";
                mainFile = Environment.ExpandEnvironmentVariables(mainFile);
                string fileStream = mainFile + "\\Knjige.xml";
                //Deletes the xml file and creates the newly update one.
                File.Delete(fileStream); //TODO: convert the old file to old back-up file
                File.AppendAllText(fileStream, knjXML.ToString());

                MessageBox.Show("Knjiga je uspješno spremljena!", "Uspješno spremljeno", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception n)
            {
                MessageBox.Show("Greška\r\n" + n, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            fAutor.Clear();
            fNaslov.Clear();
            fIzdavac.Clear();
            fAutor.Focus();
        }

    }
}
