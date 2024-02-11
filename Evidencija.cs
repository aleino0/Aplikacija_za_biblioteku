using Aplikacija_za_biblioteku;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Aplikacija_za_biblioteku
{
    internal class Evidencija
    {
        string korisnik_ID, knjiga_ID;
        DateTime datumPos, datumVrac;
        int brojPus;

        public Evidencija(string korisnik_ID, string knjiga_ID, DateTime datumPos/*, int brojPus*/)
        {
            Korisnik_ID = korisnik_ID;
            Knjiga_ID = knjiga_ID;
            DatumPos = datumPos;
            BrojPus = 1;
        }

        public string Korisnik_ID { get => korisnik_ID; set => korisnik_ID = value; }
        public string Knjiga_ID { get => knjiga_ID; set => knjiga_ID = value; }
        public DateTime DatumPos { get => datumPos; set => datumPos = value; }
        public DateTime DatumVrac { get => datumVrac; set => datumVrac = value; }
        public int BrojPus { get => brojPus; set => brojPus = value; }

        public override string ToString()
        {
            string korName = "NULL";
            string knjName = "NULL";

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
                        if (Knjiga_ID == knj.Knjiga_ID)
                        {
                            knjName = knj.Naslov;
                        }
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
                        if (Korisnik_ID == kor.Korisnik_ID)
                        {
                            korName = kor.Ime + " " + kor.Prezime;
                            //MessageBox.Show(Korisnik_ID + " " + kor.Korisnik_ID +" | "+ kor.Ime +" "+ kor.Prezime, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        /*else
                        {
                            MessageBox.Show(Korisnik_ID + " " + kor.Korisnik_ID, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }*/
                    }
                }
            }
            catch
            {
                //XML file is empty/has no <root>
            }
            string txt = "ID korisnik: " + Korisnik_ID + " | Korisnik: " + korName + " | ID knjiga: " + Knjiga_ID + " | Knjiga: " + knjName + " | Datum posuđivanje: " + DatumPos.ToString();
            if (DatumVrac != Convert.ToDateTime("0001-01-01T00:00:00"))
            {
                txt += " | Datum Vračanje: " + DatumVrac.ToString();
            }
            return txt;
        }
        public string ToStringShort()
        {
            string korName = "NULL";
            string knjName = "NULL";

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
                        if (Knjiga_ID == knj.Knjiga_ID)
                        {
                            knjName = knj.Naslov;
                        }
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
                        Korisnik kor = new Korisnik(element.Attribute("ID").Value, element.Attribute("Ime").Value, element.Attribute("Prezime").Value, element.Attribute("Email").Value, element.Attribute("Adresa").Value, Convert.ToInt32(element.Attribute("BrojTelefona").Value));
                        if (Korisnik_ID == kor.Korisnik_ID)
                        {
                            korName = kor.Ime + " " + kor.Prezime;
                        }
                    }
                }
            }
            catch
            {
                //XML file is empty/has no <root>
            }
            return "Korisnik: " + korName + " | Knjiga: " + knjName + " | DatumPosuđivanje: " + DatumPos.Day + "." + DatumPos.Month + "." + DatumPos.Year;
        }
    }
}
