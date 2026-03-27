using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banka_LeQuang
{
    internal class Ucet
    {
        public string CisloUctu { get; private set; }
        public decimal Zustatek { get; private set; }

        public Ucet(string cisloUctu, decimal pocatecniVklad)
        {
            CisloUctu = cisloUctu;
            Zustatek = pocatecniVklad;
        }

        public void VlozPenize(decimal castka)
        {
            if (castka > 0)
                Zustatek += castka;
        }

        public void VyberPenize(decimal castka)
        {
            if (castka > 0 && castka <= Zustatek)
                Zustatek -= castka;
            else
                throw new Exception("Nedostatečný zůstatek nebo neplatná částka.");
        }
    }
}