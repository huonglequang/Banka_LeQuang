using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
using System.IO;
using System.CodeDom;
using System.Data;
using System.Windows.Forms;

namespace Banka_LeQuang
{
    
    public class Klient
    {

        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public string UzivatelskeJmeno { get; set; }
        public string Heslo { get; set; }
        public Ucet Ucet { get; set; }

        public static List<Klient> Ucty = new List<Klient>();

        public Klient() { }

        public Klient(string jmeno, string prijmeni, string uzivatelskejmeno, string heslo, Ucet ucet)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            UzivatelskeJmeno = uzivatelskejmeno;
            Heslo = heslo;
            Ucet = ucet;
        }

        public static void PridejKlienta(Klient klient)
        {
            Ucty.Add(klient);
        }

        public override string ToString()
        {
            return $"{Jmeno} {Prijmeni} ({UzivatelskeJmeno})";
        }


        public static void SerializujDoXml(string filePath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Klient>));
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                serializer.Serialize(sw, Ucty);
            }
        }

        public static void DeserializujZXml(string filePath)
        {
            if (File.Exists(filePath) && new FileInfo(filePath).Length > 0)
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Klient>));
                using (StreamReader sr = new StreamReader(filePath))
                {
                    Ucty = (List<Klient>)serializer.Deserialize(sr);
                }
            }
        }
    }
}
