using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka_LeQuang
{
    internal class Klient
    {

        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public string UzivatelskeJmeno { get; set; }
        public string Heslo { get; set; }

        public static List<Klient> Ucty = new List<Klient>();

        public Klient(string jmeno, string prijmeni, string uzivatelskejmeno, string heslo)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            UzivatelskeJmeno = uzivatelskejmeno;
            Heslo = heslo;
        }

        public static void PridejKlienta(Klient klient)
        {
            Ucty.Add(klient);
        }

        public override string ToString()
        {
            return $"{Jmeno} {Prijmeni} ({UzivatelskeJmeno})";
        }

    }
}
