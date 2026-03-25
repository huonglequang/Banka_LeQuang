using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banka_LeQuang
{
    public partial class Form2 : Form
    {

        public Form2()
        {  
            InitializeComponent();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Klient novyKlient = new Klient(tb_jmeno.Text, tb_primeni.Text, tb_uzivatelskeJmeno.Text, tb_heslo.Text);
                Klient.PridejKlienta(novyKlient);
                DialogResult = DialogResult.OK;
            }
            catch (Exception)
            {
                MessageBox.Show("Něco se pokazilo, zkontrolujte znovu zadané údaje", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
