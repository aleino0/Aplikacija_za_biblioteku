using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacija_za_biblioteku
{
    internal class Knjiga
    {

        string author, naslov, izdavac, knjiga_ID;

        public Knjiga(string knjiga_ID, string author, string naslov, string izdavac)
        {
            Knjiga_ID = knjiga_ID;
            Author = author;
            Naslov = naslov;
            Izdavac = izdavac;
        }

        public string Knjiga_ID { get => knjiga_ID; set => knjiga_ID = value; }
        public string Author { get => author; set => author = value; }
        public string Naslov { get => naslov; set => naslov = value; }
        public string Izdavac { get => izdavac; set => izdavac = value; }

        public override string ToString()
        {
            return "ID: " + Knjiga_ID + " | Author: " + Author + " | Naslov: " + Naslov + " | Izdavac: " + Izdavac;
        }
    }
}
