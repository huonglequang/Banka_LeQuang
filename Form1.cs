using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banka_LeQuang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void btn_pridejKlienta_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
            if (DialogResult == DialogResult.OK)
            {
                MessageBox.Show("Klient byl úspěšně přidán.");
            }
            else
            {
                MessageBox.Show("Přidání klienta bylo zrušeno.");
            }
        }

        private void btn_upravitKlienta_Click(object sender, EventArgs e)
        {

        }
    }
}
