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
        public List<Ucet> Ucty { get; set; }

        public Klient()
        {
            Ucty = new List<Ucet>();
        }

        public override string ToString()
        {
            return $"{Jmeno} {Prijmeni}";
        }

    }
}
