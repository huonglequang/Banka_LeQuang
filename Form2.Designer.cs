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
            this.button1 = new System.Windows.Forms.Button();
            this.tb_jmeno = new System.Windows.Forms.TextBox();
            this.tb_primeni = new System.Windows.Forms.TextBox();
            this.tb_uzivatelskeJmeno = new System.Windows.Forms.TextBox();
            this.tb_heslo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_cisloUctu = new System.Windows.Forms.TextBox();
            this.label_ucet = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 22);
            this.button1.TabIndex = 0;
            this.button1.Text = "Vložit na účet";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tb_jmeno
            // 
            this.tb_jmeno.Location = new System.Drawing.Point(12, 62);
            this.tb_jmeno.Name = "tb_jmeno";
            this.tb_jmeno.Size = new System.Drawing.Size(178, 20);
            this.tb_jmeno.TabIndex = 1;
            // 
            // tb_primeni
            // 
            this.tb_primeni.Location = new System.Drawing.Point(12, 102);
            this.tb_primeni.Name = "tb_primeni";
            this.tb_primeni.Size = new System.Drawing.Size(178, 20);
            this.tb_primeni.TabIndex = 1;
            // 
            // tb_uzivatelskeJmeno
            // 
            this.tb_uzivatelskeJmeno.Location = new System.Drawing.Point(12, 141);
            this.tb_uzivatelskeJmeno.Name = "tb_uzivatelskeJmeno";
            this.tb_uzivatelskeJmeno.Size = new System.Drawing.Size(178, 20);
            this.tb_uzivatelskeJmeno.TabIndex = 1;
            // 
            // tb_heslo
            // 
            this.tb_heslo.Location = new System.Drawing.Point(12, 181);
            this.tb_heslo.Name = "tb_heslo";
            this.tb_heslo.Size = new System.Drawing.Size(178, 20);
            this.tb_heslo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Jméno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Přijmení";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Uživatelske jméno";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Heslo";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(23, 149);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 19);
            this.button2.TabIndex = 0;
            this.button2.Text = "Vybrat z účtu";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(167, 264);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 35);
            this.button3.TabIndex = 0;
            this.button3.Text = "OK";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 63);
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
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(23, 79);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(103, 20);
            this.numericUpDown1.TabIndex = 3;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(23, 41);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(103, 20);
            this.numericUpDown2.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.numericUpDown2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(269, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(171, 174);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Penezni operace";
            // 
            // tb_cisloUctu
            // 
            this.tb_cisloUctu.Location = new System.Drawing.Point(12, 222);
            this.tb_cisloUctu.Name = "tb_cisloUctu";
            this.tb_cisloUctu.Size = new System.Drawing.Size(178, 20);
            this.tb_cisloUctu.TabIndex = 1;
            // 
            // label_ucet
            // 
            this.label_ucet.AutoSize = true;
            this.label_ucet.Location = new System.Drawing.Point(12, 206);
            this.label_ucet.Name = "label_ucet";
            this.label_ucet.Size = new System.Drawing.Size(55, 13);
            this.label_ucet.TabIndex = 2;
            this.label_ucet.Text = "Cislo Uctu";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label_ucet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_cisloUctu);
            this.Controls.Add(this.tb_heslo);
            this.Controls.Add(this.tb_uzivatelskeJmeno);
            this.Controls.Add(this.tb_primeni);
            this.Controls.Add(this.tb_jmeno);
            this.Controls.Add(this.button3);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tb_jmeno;
        private System.Windows.Forms.TextBox tb_primeni;
        private System.Windows.Forms.TextBox tb_uzivatelskeJmeno;
        private System.Windows.Forms.TextBox tb_heslo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_cisloUctu;
        private System.Windows.Forms.Label label_ucet;
    }
}