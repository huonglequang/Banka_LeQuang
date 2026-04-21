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
        string Mode;

        public Form2(Klient user, string mode)
        {
            InitializeComponent();
            User = user;
            Mode = mode;
            nud_castka.DecimalPlaces = 2;
            nud_castka.Minimum = 0;
            nud_castka.Maximum = decimal.MaxValue;
            nud_castka.Maximum = 1000000000;
 

            if (User == null && Mode == "add")
            {
                label_ucet.Visible = false;
                tb_cisloUctu.Visible = false;
                gb_operace.Visible = false;
            }

            else if (User != null && Mode == "edit")
            {
                tb_jmeno.Text = User.Jmeno;
                tb_primeni.Text = User.Prijmeni;
                tb_uzivatelskeJmeno.Text = User.UzivatelskeJmeno;
                tb_heslo.Text = User.Heslo;
                tb_cisloUctu.Text = User.Ucet.CisloUctu;
                tb_zustatek.Text = Convert.ToString(User.Ucet.Zustatek);
                tb_cisloUctu.ReadOnly = true;
                tb_zustatek.Text = Convert.ToString(User.Ucet.Zustatek);
                tb_zustatek.Enabled = false;
                nud_castka.Enabled = false;
                btn_vklad.Enabled = false;
                btn_vyber.Enabled = false;
            }

            else if (User != null && Mode == "finance")
            {
                tb_jmeno.Text = User.Jmeno;
                tb_jmeno.ReadOnly = true;
                tb_primeni.Text = User.Prijmeni;
                tb_primeni.ReadOnly = true;
                tb_uzivatelskeJmeno.Text = User.UzivatelskeJmeno;
                tb_uzivatelskeJmeno.ReadOnly = true;
                tb_heslo.Text = User.Heslo;
                tb_heslo.ReadOnly = true;
                tb_cisloUctu.Text = User.Ucet.CisloUctu;
                tb_cisloUctu.ReadOnly = true;
                tb_zustatek.Text = Convert.ToString(User.Ucet.Zustatek);

            }

        }
        private void btn_vklad_Click(object sender, EventArgs e)
        {
            try
            {
                if (nud_castka.Value > 0)
                {
                    User.Ucet.VlozPenize(nud_castka.Value);
                    nud_castka.Value = 0;
                    tb_zustatek.Text = Convert.ToString(User.Ucet.Zustatek);
                }    
                else
                    MessageBox.Show("Zadejte kladnou částku pro vklad.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_vyber_Click(object sender, EventArgs e)
        {
            try
            {
                if (nud_castka.Value > 0 && nud_castka.Value <= User.Ucet.Zustatek)
                {
                    User.Ucet.VyberPenize(nud_castka.Value);
                    nud_castka.Value = 0;
                    tb_zustatek.Text = Convert.ToString(User.Ucet.Zustatek);
                }
                else
                {
                    MessageBox.Show("Nedostatečný zůstatek na účtu.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (User == null && Mode == "add")
            {
                try
                {
                    Random rnd = new Random();
                    string cisloUctu = rnd.Next(100000, 999999).ToString();
                    while (Klient.Ucty.Any(k => k.Ucet != null && k.Ucet.CisloUctu == cisloUctu))
                    {
                        cisloUctu = rnd.Next(100000, 999999).ToString();
                    }
                    Ucet novyUcet = new Ucet(cisloUctu);

                    Klient novyKlient = new Klient(tb_jmeno.Text, tb_primeni.Text, tb_uzivatelskeJmeno.Text, tb_heslo.Text, novyUcet);
                    Klient.PridejKlienta(novyKlient);
                    DialogResult = DialogResult.OK;
                }
                catch (Exception)
                {
                    MessageBox.Show("Něco se pokazilo, zkontrolujte znovu zadané údaje", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DialogResult = DialogResult.None;
                }
            }
            else if (User != null && Mode == "edit")
            {
                try
                {
                    Klient upravenyKlient = new Klient(tb_jmeno.Text, tb_primeni.Text, tb_uzivatelskeJmeno.Text, tb_heslo.Text, User.Ucet);
                    Klient.PridejKlienta(upravenyKlient);
                    DialogResult = DialogResult.OK;
                }
                catch (Exception)
                {
                    MessageBox.Show("Něco se pokazilo, zkontrolujte znovu zadané údaje", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DialogResult = DialogResult.None;
                }

            }
            else if (User != null && Mode == "finance")
            {


                try
                {
                    Klient upravenyKlient = new Klient(tb_jmeno.Text, tb_primeni.Text, tb_uzivatelskeJmeno.Text, tb_heslo.Text, User.Ucet);
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
