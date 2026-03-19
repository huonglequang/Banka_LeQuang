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
        public string CisloUctu { get; set; }
        public decimal Zustatek { get; set; }


        public void vybratPenize(int castka)
        {
            if (castka > Zustatek)
            {
                MessageBox.Show("Nedostatečný zůstatek na účtu.");
            }
            Zustatek -= castka;
            MessageBox.Show($"Vybráno: {castka} Kč. Zůstatek: {Zustatek} Kč.");
        }

        public void vlozitPenize(int castka)
        {
            Zustatek += castka;
            MessageBox.Show($"Vloženo: {castka} Kč. Zůstatek: {Zustatek} Kč.");
        }
    }
}