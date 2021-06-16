namespace Windows_Forms_Aplikacija.Forme
{
    partial class Igraci
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
            this.listaIgraca = new System.Windows.Forms.ListBox();
            this.pbSlikaIgraca = new System.Windows.Forms.PictureBox();
            this.tbIme = new System.Windows.Forms.TextBox();
            this.tbPrezime = new System.Windows.Forms.TextBox();
            this.btnUcitajSliku = new System.Windows.Forms.Button();
            this.btnDalje = new System.Windows.Forms.Button();
            this.lbIme = new System.Windows.Forms.Label();
            this.lbPrezime = new System.Windows.Forms.Label();
            this.lbOmiljeni = new System.Windows.Forms.Label();
            this.tbSpremanje = new System.Windows.Forms.TextBox();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.promjenaJezikaINacijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.promjenaNatjecanjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izlazakIzAplikacijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlikaIgraca)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listaIgraca
            // 
            this.listaIgraca.BackColor = System.Drawing.Color.PaleGreen;
            this.listaIgraca.FormattingEnabled = true;
            this.listaIgraca.ItemHeight = 16;
            this.listaIgraca.Location = new System.Drawing.Point(12, 44);
            this.listaIgraca.Name = "listaIgraca";
            this.listaIgraca.Size = new System.Drawing.Size(283, 436);
            this.listaIgraca.TabIndex = 0;
            this.listaIgraca.SelectedIndexChanged += new System.EventHandler(this.ListaIgraca_SelectedIndexChanged);
            // 
            // pbSlikaIgraca
            // 
            this.pbSlikaIgraca.BackColor = System.Drawing.Color.Transparent;
            this.pbSlikaIgraca.Location = new System.Drawing.Point(485, 156);
            this.pbSlikaIgraca.Name = "pbSlikaIgraca";
            this.pbSlikaIgraca.Size = new System.Drawing.Size(242, 212);
            this.pbSlikaIgraca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSlikaIgraca.TabIndex = 1;
            this.pbSlikaIgraca.TabStop = false;
            // 
            // tbIme
            // 
            this.tbIme.BackColor = System.Drawing.Color.LightGreen;
            this.tbIme.Location = new System.Drawing.Point(485, 114);
            this.tbIme.Name = "tbIme";
            this.tbIme.ReadOnly = true;
            this.tbIme.Size = new System.Drawing.Size(124, 22);
            this.tbIme.TabIndex = 2;
            // 
            // tbPrezime
            // 
            this.tbPrezime.BackColor = System.Drawing.Color.LightGreen;
            this.tbPrezime.Location = new System.Drawing.Point(615, 114);
            this.tbPrezime.Name = "tbPrezime";
            this.tbPrezime.ReadOnly = true;
            this.tbPrezime.Size = new System.Drawing.Size(112, 22);
            this.tbPrezime.TabIndex = 3;
            // 
            // btnUcitajSliku
            // 
            this.btnUcitajSliku.BackColor = System.Drawing.Color.PaleGreen;
            this.btnUcitajSliku.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUcitajSliku.Location = new System.Drawing.Point(485, 393);
            this.btnUcitajSliku.Name = "btnUcitajSliku";
            this.btnUcitajSliku.Size = new System.Drawing.Size(133, 35);
            this.btnUcitajSliku.TabIndex = 4;
            this.btnUcitajSliku.Text = "Ucitaj Sliku";
            this.btnUcitajSliku.UseVisualStyleBackColor = false;
            this.btnUcitajSliku.Click += new System.EventHandler(this.BtnUcitajSliku_Click);
            // 
            // btnDalje
            // 
            this.btnDalje.BackColor = System.Drawing.Color.PaleGreen;
            this.btnDalje.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDalje.Location = new System.Drawing.Point(709, 44);
            this.btnDalje.Name = "btnDalje";
            this.btnDalje.Size = new System.Drawing.Size(79, 33);
            this.btnDalje.TabIndex = 5;
            this.btnDalje.Text = "Dalje";
            this.btnDalje.UseVisualStyleBackColor = false;
            this.btnDalje.Click += new System.EventHandler(this.BtnDalje_Click);
            // 
            // lbIme
            // 
            this.lbIme.AutoSize = true;
            this.lbIme.BackColor = System.Drawing.Color.LightGreen;
            this.lbIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIme.Location = new System.Drawing.Point(523, 91);
            this.lbIme.Name = "lbIme";
            this.lbIme.Size = new System.Drawing.Size(41, 20);
            this.lbIme.TabIndex = 6;
            this.lbIme.Text = "Ime:";
            // 
            // lbPrezime
            // 
            this.lbPrezime.AutoSize = true;
            this.lbPrezime.BackColor = System.Drawing.Color.LightGreen;
            this.lbPrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrezime.Location = new System.Drawing.Point(625, 91);
            this.lbPrezime.Name = "lbPrezime";
            this.lbPrezime.Size = new System.Drawing.Size(76, 20);
            this.lbPrezime.TabIndex = 7;
            this.lbPrezime.Text = "Prezime:";
            // 
            // lbOmiljeni
            // 
            this.lbOmiljeni.AutoSize = true;
            this.lbOmiljeni.BackColor = System.Drawing.Color.LightGreen;
            this.lbOmiljeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOmiljeni.Location = new System.Drawing.Point(733, 114);
            this.lbOmiljeni.Name = "lbOmiljeni";
            this.lbOmiljeni.Size = new System.Drawing.Size(0, 20);
            this.lbOmiljeni.TabIndex = 8;
            // 
            // tbSpremanje
            // 
            this.tbSpremanje.Location = new System.Drawing.Point(485, 451);
            this.tbSpremanje.Name = "tbSpremanje";
            this.tbSpremanje.ReadOnly = true;
            this.tbSpremanje.Size = new System.Drawing.Size(242, 22);
            this.tbSpremanje.TabIndex = 9;
            // 
            // btnSpremi
            // 
            this.btnSpremi.BackColor = System.Drawing.Color.PaleGreen;
            this.btnSpremi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpremi.Location = new System.Drawing.Point(629, 393);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(98, 35);
            this.btnSpremi.TabIndex = 10;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = false;
            this.btnSpremi.Click += new System.EventHandler(this.BtnSpremi_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.PaleGreen;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.Color.LightGreen;
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.promjenaJezikaINacijeToolStripMenuItem,
            this.promjenaNatjecanjaToolStripMenuItem,
            this.izlazakIzAplikacijeToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(80, 24);
            this.toolStripMenuItem1.Text = "Postavke";
            // 
            // promjenaJezikaINacijeToolStripMenuItem
            // 
            this.promjenaJezikaINacijeToolStripMenuItem.Name = "promjenaJezikaINacijeToolStripMenuItem";
            this.promjenaJezikaINacijeToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.promjenaJezikaINacijeToolStripMenuItem.Text = "Promjena jezika i nacije";
            this.promjenaJezikaINacijeToolStripMenuItem.Click += new System.EventHandler(this.PromjenaJezikaINacijeToolStripMenuItem_Click);
            // 
            // promjenaNatjecanjaToolStripMenuItem
            // 
            this.promjenaNatjecanjaToolStripMenuItem.Name = "promjenaNatjecanjaToolStripMenuItem";
            this.promjenaNatjecanjaToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.promjenaNatjecanjaToolStripMenuItem.Text = "Promjena natjecanja";
            this.promjenaNatjecanjaToolStripMenuItem.Click += new System.EventHandler(this.PromjenaNatjecanjaToolStripMenuItem_Click);
            // 
            // izlazakIzAplikacijeToolStripMenuItem
            // 
            this.izlazakIzAplikacijeToolStripMenuItem.Name = "izlazakIzAplikacijeToolStripMenuItem";
            this.izlazakIzAplikacijeToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.izlazakIzAplikacijeToolStripMenuItem.Text = "Izlazak iz aplikacije";
            this.izlazakIzAplikacijeToolStripMenuItem.Click += new System.EventHandler(this.IzlazakIzAplikacijeToolStripMenuItem_Click);
            // 
            // Igraci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Windows_Forms_Aplikacija.Properties.Resources.Pocetna_Slika;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 485);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.tbSpremanje);
            this.Controls.Add(this.lbOmiljeni);
            this.Controls.Add(this.lbPrezime);
            this.Controls.Add(this.lbIme);
            this.Controls.Add(this.btnDalje);
            this.Controls.Add(this.btnUcitajSliku);
            this.Controls.Add(this.tbPrezime);
            this.Controls.Add(this.tbIme);
            this.Controls.Add(this.pbSlikaIgraca);
            this.Controls.Add(this.listaIgraca);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Igraci";
            this.Text = "Igraci";
            this.Load += new System.EventHandler(this.Igraci_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbSlikaIgraca)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listaIgraca;
        private System.Windows.Forms.PictureBox pbSlikaIgraca;
        private System.Windows.Forms.TextBox tbIme;
        private System.Windows.Forms.TextBox tbPrezime;
        private System.Windows.Forms.Button btnUcitajSliku;
        private System.Windows.Forms.Button btnDalje;
        private System.Windows.Forms.Label lbIme;
        private System.Windows.Forms.Label lbPrezime;
        private System.Windows.Forms.Label lbOmiljeni;
        private System.Windows.Forms.TextBox tbSpremanje;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem promjenaJezikaINacijeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem promjenaNatjecanjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izlazakIzAplikacijeToolStripMenuItem;
    }
}