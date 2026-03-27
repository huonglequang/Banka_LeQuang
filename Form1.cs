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
            Klient User = null;
            Form2 f2 = new Form2(User);
            f2.ShowDialog();
            if (f2.DialogResult == DialogResult.OK)
            {
                listBox1.Items.Clear();
                foreach (var klient in Klient.Ucty)
                {
                    listBox1.Items.Add(klient);
                }
            }
        }

        private void btn_upravitKlienta_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                Klient User = (Klient)listBox1.SelectedItem;
                Form2 f2 = new Form2(User);
                f2.ShowDialog();
                if (f2.DialogResult == DialogResult.OK)
                {
                    Klient.Ucty.Remove(User);
                    listBox1.Items.Clear();
                    foreach (var klient in Klient.Ucty)
                    {
                        listBox1.Items.Add(klient);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vyberte klienta, kterého chcete upravit.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_odstranKlienta_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                Klient User = (Klient)listBox1.SelectedItem;
                Klient.Ucty.Remove(User);
                listBox1.Items.Clear();
                foreach (var klient in Klient.Ucty)
                {
                    listBox1.Items.Add(klient);
                }
            }
        }
    }
}
