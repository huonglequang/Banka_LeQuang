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
        Klient User;

        public Form2(Klient user)
        {
            InitializeComponent();
            User = user;

            if (User != null)
            {
                tb_jmeno.Text = User.Jmeno;
                tb_primeni.Text = User.Prijmeni;
                tb_uzivatelskeJmeno.Text = User.UzivatelskeJmeno;
                tb_heslo.Text = User.Heslo;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (User == null)
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
                    DialogResult = DialogResult.None;
                }
            }
            else
            {
                try
                {
                    Klient upravenyKlient = new Klient(tb_jmeno.Text, tb_primeni.Text, tb_uzivatelskeJmeno.Text, tb_heslo.Text);
                    Klient.PridejKlienta(upravenyKlient);
                    DialogResult = DialogResult.OK;
                }
                catch (Exception)
                {
                    MessageBox.Show("Něco se pokazilo, zkontrolujte znovu zadané údaje", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DialogResult = DialogResult.None;
                }

            }
        }
    }
}
