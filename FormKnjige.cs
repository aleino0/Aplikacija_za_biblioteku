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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Aplikacija_za_biblioteku
{
    public partial class FormKnjige : Form
    {
        //Makes List of book objects
        List<Knjiga> list = new List<Knjiga>();
        public FormKnjige()
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
                        listKnjige.Items.Add(knj.ToString());
                        list.Add(knj);
                    }
                }
            }
            catch
            {
                //XML file is empty/has no <root>
            }

        }

        private void btnTrazi_Click(object sender, EventArgs e)
        {
            listKnjige.Items.Clear();
            string search = textBox1.Text;
            foreach (Knjiga knjiga in list)
            {
                if (knjiga.Izdavac.StartsWith(search) == true || knjiga.Naslov.StartsWith(search) == true || knjiga.Knjiga_ID.StartsWith(search) == true || knjiga.Author.StartsWith(search) == true || search == "")
                {
                    listKnjige.Items.Add(knjiga.ToString());
                }

            }
        }
    }
}
