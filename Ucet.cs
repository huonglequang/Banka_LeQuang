using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banka_LeQuang
{
    public class Ucet
    {
        public string CisloUctu { get; set; }
        public decimal Zustatek { get; set; }

        public Ucet () { }
        
        public Ucet(string cisloUctu)
        {
            CisloUctu = cisloUctu;
            Zustatek = 0;
        }

        public override string ToString()
        {
            return CisloUctu;
        }

        public void VlozPenize(decimal castka)
        {
                Zustatek += castka;

        }

        public void VyberPenize(decimal castka)
        {
            if (castka > 0 && castka <= Zustatek)
                Zustatek -= castka;
            else
                MessageBox.Show("Nedostatečný zůstatek na účtu.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}