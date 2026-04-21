namespace Banka_LeQuang
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_vklad = new System.Windows.Forms.Button();
            this.tb_jmeno = new System.Windows.Forms.TextBox();
            this.tb_primeni = new System.Windows.Forms.TextBox();
            this.tb_uzivatelskeJmeno = new System.Windows.Forms.TextBox();
            this.tb_heslo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_vyber = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nud_castka = new System.Windows.Forms.NumericUpDown();
            this.gb_operace = new System.Windows.Forms.GroupBox();
            this.tb_cisloUctu = new System.Windows.Forms.TextBox();
            this.label_ucet = new System.Windows.Forms.Label();
            this.gb_informace = new System.Windows.Forms.GroupBox();
            this.tb_zustatek = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nud_castka)).BeginInit();
            this.gb_operace.SuspendLayout();
            this.gb_informace.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_vklad
            // 
            this.btn_vklad.Location = new System.Drawing.Point(23, 118);
            this.btn_vklad.Name = "btn_vklad";
            this.btn_vklad.Size = new System.Drawing.Size(119, 41);
            this.btn_vklad.TabIndex = 0;
            this.btn_vklad.Text = "Vložit na účet";
            this.btn_vklad.UseVisualStyleBackColor = true;
            this.btn_vklad.Click += new System.EventHandler(this.btn_vklad_Click);
            // 
            // tb_jmeno
            // 
            this.tb_jmeno.Location = new System.Drawing.Point(17, 39);
            this.tb_jmeno.Name = "tb_jmeno";
            this.tb_jmeno.Size = new System.Drawing.Size(178, 20);
            this.tb_jmeno.TabIndex = 1;
            // 
            // tb_primeni
            // 
            this.tb_primeni.Location = new System.Drawing.Point(17, 78);
            this.tb_primeni.Name = "tb_primeni";
            this.tb_primeni.Size = new System.Drawing.Size(178, 20);
            this.tb_primeni.TabIndex = 1;
            // 
            // tb_uzivatelskeJmeno
            // 
            this.tb_uzivatelskeJmeno.Location = new System.Drawing.Point(17, 117);
            this.tb_uzivatelskeJmeno.Name = "tb_uzivatelskeJmeno";
            this.tb_uzivatelskeJmeno.Size = new System.Drawing.Size(178, 20);
            this.tb_uzivatelskeJmeno.TabIndex = 1;
            // 
            // tb_heslo
            // 
            this.tb_heslo.Location = new System.Drawing.Point(17, 158);
            this.tb_heslo.Name = "tb_heslo";
            this.tb_heslo.Size = new System.Drawing.Size(178, 20);
            this.tb_heslo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Jméno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Přijmení";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Uživatelske jméno";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Heslo";
            // 
            // btn_vyber
            // 
            this.btn_vyber.Location = new System.Drawing.Point(23, 168);
            this.btn_vyber.Name = "btn_vyber";
            this.btn_vyber.Size = new System.Drawing.Size(119, 42);
            this.btn_vyber.TabIndex = 0;
            this.btn_vyber.Text = "Vybrat z účtu";
            this.btn_vyber.UseVisualStyleBackColor = true;
            this.btn_vyber.Click += new System.EventHandler(this.btn_vyber_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(27, 300);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(421, 122);
            this.button3.TabIndex = 0;
            this.button3.Text = "OK";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Částka";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Zůstatek";
            // 
            // nud_castka
            // 
            this.nud_castka.Location = new System.Drawing.Point(23, 84);
            this.nud_castka.Name = "nud_castka";
            this.nud_castka.Size = new System.Drawing.Size(119, 20);
            this.nud_castka.TabIndex = 3;
            // 
            // gb_operace
            // 
            this.gb_operace.Controls.Add(this.tb_zustatek);
            this.gb_operace.Controls.Add(this.nud_castka);
            this.gb_operace.Controls.Add(this.btn_vklad);
            this.gb_operace.Controls.Add(this.btn_vyber);
            this.gb_operace.Controls.Add(this.label5);
            this.gb_operace.Controls.Add(this.label6);
            this.gb_operace.Location = new System.Drawing.Point(277, 31);
            this.gb_operace.Name = "gb_operace";
            this.gb_operace.Size = new System.Drawing.Size(171, 227);
            this.gb_operace.TabIndex = 4;
            this.gb_operace.TabStop = false;
            this.gb_operace.Text = "Penezni operace";
            // 
            // tb_cisloUctu
            // 
            this.tb_cisloUctu.Location = new System.Drawing.Point(17, 200);
            this.tb_cisloUctu.Name = "tb_cisloUctu";
            this.tb_cisloUctu.Size = new System.Drawing.Size(178, 20);
            this.tb_cisloUctu.TabIndex = 1;
            // 
            // label_ucet
            // 
            this.label_ucet.AutoSize = true;
            this.label_ucet.Location = new System.Drawing.Point(17, 181);
            this.label_ucet.Name = "label_ucet";
            this.label_ucet.Size = new System.Drawing.Size(55, 13);
            this.label_ucet.TabIndex = 2;
            this.label_ucet.Text = "Cislo Uctu";
            // 
            // gb_informace
            // 
            this.gb_informace.Controls.Add(this.label1);
            this.gb_informace.Controls.Add(this.tb_jmeno);
            this.gb_informace.Controls.Add(this.label_ucet);
            this.gb_informace.Controls.Add(this.tb_primeni);
            this.gb_informace.Controls.Add(this.label4);
            this.gb_informace.Controls.Add(this.tb_uzivatelskeJmeno);
            this.gb_informace.Controls.Add(this.label3);
            this.gb_informace.Controls.Add(this.tb_heslo);
            this.gb_informace.Controls.Add(this.label2);
            this.gb_informace.Controls.Add(this.tb_cisloUctu);
            this.gb_informace.Location = new System.Drawing.Point(27, 21);
            this.gb_informace.Name = "gb_informace";
            this.gb_informace.Size = new System.Drawing.Size(211, 237);
            this.gb_informace.TabIndex = 5;
            this.gb_informace.TabStop = false;
            this.gb_informace.Text = "Informace o účtě";
            // 
            // tb_zustatek
            // 
            this.tb_zustatek.Location = new System.Drawing.Point(22, 43);
            this.tb_zustatek.Name = "tb_zustatek";
            this.tb_zustatek.ReadOnly = true;
            this.tb_zustatek.Size = new System.Drawing.Size(119, 20);
            this.tb_zustatek.TabIndex = 4;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gb_informace);
            this.Controls.Add(this.gb_operace);
            this.Controls.Add(this.button3);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.nud_castka)).EndInit();
            this.gb_operace.ResumeLayout(false);
            this.gb_operace.PerformLayout();
            this.gb_informace.ResumeLayout(false);
            this.gb_informace.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_vklad;
        private System.Windows.Forms.TextBox tb_jmeno;
        private System.Windows.Forms.TextBox tb_primeni;
        private System.Windows.Forms.TextBox tb_uzivatelskeJmeno;
        private System.Windows.Forms.TextBox tb_heslo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_vyber;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nud_castka;
        private System.Windows.Forms.GroupBox gb_operace;
        private System.Windows.Forms.TextBox tb_cisloUctu;
        private System.Windows.Forms.Label label_ucet;
        private System.Windows.Forms.GroupBox gb_informace;
        private System.Windows.Forms.TextBox tb_zustatek;
    }
}