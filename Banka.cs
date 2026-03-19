using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banka_LeQuang
{
    internal class Banka
    {
        public List<Klient> Klienti { get; set; }

        public Banka()
        {
            Klienti = new List<Klient>();
        }

        public void PridejKlienta(Klient k)
        {
            if (Klienti.Contains(k))
            {
                MessageBox.Show("Uzivatel jiz existuje");
            }
            else Klienti.Add(k);
        }

        public void OdeberKlienta(Klient k)
        {
            Klienti.Remove(k);
        }
    }
}
