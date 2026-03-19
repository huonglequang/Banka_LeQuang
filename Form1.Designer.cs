namespace Banka_LeQuang
{
    partial class Form1
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_pridejKlienta = new System.Windows.Forms.Button();
            this.btn_odstranKlienta = new System.Windows.Forms.Button();
            this.btn_upravitKlienta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(383, 35);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(277, 355);
            this.listBox1.TabIndex = 0;
            // 
            // btn_pridejKlienta
            // 
            this.btn_pridejKlienta.Location = new System.Drawing.Point(134, 48);
            this.btn_pridejKlienta.Name = "btn_pridejKlienta";
            this.btn_pridejKlienta.Size = new System.Drawing.Size(183, 40);
            this.btn_pridejKlienta.TabIndex = 1;
            this.btn_pridejKlienta.Text = "Přidat klienta";
            this.btn_pridejKlienta.UseVisualStyleBackColor = true;
            this.btn_pridejKlienta.Click += new System.EventHandler(this.btn_pridejKlienta_Click);
            // 
            // btn_odstranKlienta
            // 
            this.btn_odstranKlienta.Location = new System.Drawing.Point(134, 104);
            this.btn_odstranKlienta.Name = "btn_odstranKlienta";
            this.btn_odstranKlienta.Size = new System.Drawing.Size(183, 40);
            this.btn_odstranKlienta.TabIndex = 1;
            this.btn_odstranKlienta.Text = "Odstranit klienta";
            this.btn_odstranKlienta.UseVisualStyleBackColor = true;
            // 
            // btn_upravitKlienta
            // 
            this.btn_upravitKlienta.Location = new System.Drawing.Point(134, 165);
            this.btn_upravitKlienta.Name = "btn_upravitKlienta";
            this.btn_upravitKlienta.Size = new System.Drawing.Size(183, 40);
            this.btn_upravitKlienta.TabIndex = 1;
            this.btn_upravitKlienta.Text = "Upravit klienta";
            this.btn_upravitKlienta.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_upravitKlienta);
            this.Controls.Add(this.btn_odstranKlienta);
            this.Controls.Add(this.btn_pridejKlienta);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "hlavniFormular";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_pridejKlienta;
        private System.Windows.Forms.Button btn_odstranKlienta;
        private System.Windows.Forms.Button btn_upravitKlienta;
    }
}

