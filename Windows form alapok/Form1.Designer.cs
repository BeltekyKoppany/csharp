namespace Windows_form_alapok
{
    partial class hobbik
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
            this.nev = new System.Windows.Forms.Label();
            this.ujHobbi = new System.Windows.Forms.Label();
            this.kedvencHobbi = new System.Windows.Forms.Label();
            this.nem = new System.Windows.Forms.Label();
            this.szulDatum = new System.Windows.Forms.Label();
            this.hozzaAd = new System.Windows.Forms.Button();
            this.betoltes = new System.Windows.Forms.Button();
            this.mentes = new System.Windows.Forms.Button();
            this.no = new System.Windows.Forms.RadioButton();
            this.ferfi = new System.Windows.Forms.RadioButton();
            this.textBoxNev = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.szulDatumPicker = new System.Windows.Forms.DateTimePicker();
            this.hobbiLista = new System.Windows.Forms.ListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // nev
            // 
            this.nev.AutoSize = true;
            this.nev.Location = new System.Drawing.Point(76, 29);
            this.nev.Name = "nev";
            this.nev.Size = new System.Drawing.Size(37, 17);
            this.nev.TabIndex = 0;
            this.nev.Text = "Név:";
            // 
            // ujHobbi
            // 
            this.ujHobbi.AutoSize = true;
            this.ujHobbi.Location = new System.Drawing.Point(476, 255);
            this.ujHobbi.Name = "ujHobbi";
            this.ujHobbi.Size = new System.Drawing.Size(64, 17);
            this.ujHobbi.TabIndex = 1;
            this.ujHobbi.Text = "Új hobbi:";
            // 
            // kedvencHobbi
            // 
            this.kedvencHobbi.AutoSize = true;
            this.kedvencHobbi.Location = new System.Drawing.Point(622, 9);
            this.kedvencHobbi.Name = "kedvencHobbi";
            this.kedvencHobbi.Size = new System.Drawing.Size(106, 17);
            this.kedvencHobbi.TabIndex = 2;
            this.kedvencHobbi.Text = "Kedvenc hobbi:";
            // 
            // nem
            // 
            this.nem.AutoSize = true;
            this.nem.Location = new System.Drawing.Point(72, 124);
            this.nem.Name = "nem";
            this.nem.Size = new System.Drawing.Size(41, 17);
            this.nem.TabIndex = 3;
            this.nem.Text = "Nem:";
            // 
            // szulDatum
            // 
            this.szulDatum.AutoSize = true;
            this.szulDatum.Location = new System.Drawing.Point(27, 70);
            this.szulDatum.Name = "szulDatum";
            this.szulDatum.Size = new System.Drawing.Size(86, 17);
            this.szulDatum.TabIndex = 4;
            this.szulDatum.Text = "Szül. dátum:";
            // 
            // hozzaAd
            // 
            this.hozzaAd.Location = new System.Drawing.Point(564, 290);
            this.hozzaAd.Name = "hozzaAd";
            this.hozzaAd.Size = new System.Drawing.Size(161, 34);
            this.hozzaAd.TabIndex = 5;
            this.hozzaAd.Text = "Hozzáad";
            this.hozzaAd.UseVisualStyleBackColor = true;
            this.hozzaAd.Click += new System.EventHandler(this.hozzaAd_Click);
            // 
            // betoltes
            // 
            this.betoltes.Location = new System.Drawing.Point(625, 392);
            this.betoltes.Name = "betoltes";
            this.betoltes.Size = new System.Drawing.Size(100, 46);
            this.betoltes.TabIndex = 6;
            this.betoltes.Text = "Betöltés";
            this.betoltes.UseVisualStyleBackColor = true;
            // 
            // mentes
            // 
            this.mentes.Location = new System.Drawing.Point(479, 392);
            this.mentes.Name = "mentes";
            this.mentes.Size = new System.Drawing.Size(117, 46);
            this.mentes.TabIndex = 7;
            this.mentes.Text = "Mentés";
            this.mentes.UseVisualStyleBackColor = true;
            this.mentes.Click += new System.EventHandler(this.mentes_Click);
            // 
            // no
            // 
            this.no.AutoSize = true;
            this.no.Location = new System.Drawing.Point(152, 122);
            this.no.Name = "no";
            this.no.Size = new System.Drawing.Size(39, 21);
            this.no.TabIndex = 8;
            this.no.TabStop = true;
            this.no.Text = "N";
            this.no.UseVisualStyleBackColor = true;
            // 
            // ferfi
            // 
            this.ferfi.AutoSize = true;
            this.ferfi.Location = new System.Drawing.Point(238, 122);
            this.ferfi.Name = "ferfi";
            this.ferfi.Size = new System.Drawing.Size(37, 21);
            this.ferfi.TabIndex = 9;
            this.ferfi.TabStop = true;
            this.ferfi.Text = "F";
            this.ferfi.UseVisualStyleBackColor = true;
            // 
            // textBoxNev
            // 
            this.textBoxNev.Location = new System.Drawing.Point(152, 24);
            this.textBoxNev.Name = "textBoxNev";
            this.textBoxNev.Size = new System.Drawing.Size(221, 22);
            this.textBoxNev.TabIndex = 11;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(593, 255);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 13;
            // 
            // szulDatumPicker
            // 
            this.szulDatumPicker.Location = new System.Drawing.Point(152, 70);
            this.szulDatumPicker.Name = "szulDatumPicker";
            this.szulDatumPicker.Size = new System.Drawing.Size(221, 22);
            this.szulDatumPicker.TabIndex = 14;
            // 
            // hobbiLista
            // 
            this.hobbiLista.FormattingEnabled = true;
            this.hobbiLista.ItemHeight = 16;
            this.hobbiLista.Location = new System.Drawing.Point(553, 29);
            this.hobbiLista.Name = "hobbiLista";
            this.hobbiLista.Size = new System.Drawing.Size(235, 196);
            this.hobbiLista.TabIndex = 15;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // hobbik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.hobbiLista);
            this.Controls.Add(this.szulDatumPicker);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBoxNev);
            this.Controls.Add(this.ferfi);
            this.Controls.Add(this.no);
            this.Controls.Add(this.mentes);
            this.Controls.Add(this.betoltes);
            this.Controls.Add(this.hozzaAd);
            this.Controls.Add(this.szulDatum);
            this.Controls.Add(this.nem);
            this.Controls.Add(this.kedvencHobbi);
            this.Controls.Add(this.ujHobbi);
            this.Controls.Add(this.nev);
            this.Name = "hobbik";
            this.Text = "Hobbik";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nev;
        private System.Windows.Forms.Label ujHobbi;
        private System.Windows.Forms.Label kedvencHobbi;
        private System.Windows.Forms.Label nem;
        private System.Windows.Forms.Label szulDatum;
        private System.Windows.Forms.Button hozzaAd;
        private System.Windows.Forms.Button betoltes;
        private System.Windows.Forms.Button mentes;
        private System.Windows.Forms.RadioButton no;
        private System.Windows.Forms.RadioButton ferfi;
        private System.Windows.Forms.TextBox textBoxNev;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.DateTimePicker szulDatumPicker;
        private System.Windows.Forms.ListBox hobbiLista;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

