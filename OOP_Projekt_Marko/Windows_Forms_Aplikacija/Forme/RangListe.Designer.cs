namespace Windows_Forms_Aplikacija.Forme
{
    partial class RangListe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RangListe));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnPrintGolovi = new System.Windows.Forms.Button();
            this.lbBrojGolova = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbPrezime = new System.Windows.Forms.Label();
            this.lbIme = new System.Windows.Forms.Label();
            this.pbGolovi = new System.Windows.Forms.PictureBox();
            this.lbgolovi = new System.Windows.Forms.ListBox();
            this.lbNaslovGolovi = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.promjenaJezikaINacijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.promjenaNatjecanjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izlazakIzAplikacijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lbBrojKartona = new System.Windows.Forms.Label();
            this.lbPrezimeKartoni = new System.Windows.Forms.Label();
            this.lbImeKartoni = new System.Windows.Forms.Label();
            this.btnPrintKartoni = new System.Windows.Forms.Button();
            this.pbKartoni = new System.Windows.Forms.PictureBox();
            this.lbNaslovKartoni = new System.Windows.Forms.Label();
            this.listaKartoni = new System.Windows.Forms.ListBox();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.promjenaJezikaINacijeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.promjenaNatjecanjaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.izlazakIzAplikacijeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lbNaslovPosjecenost = new System.Windows.Forms.Label();
            this.lbAwayTeam = new System.Windows.Forms.Label();
            this.lbHomeTeam = new System.Windows.Forms.Label();
            this.lbBrojPosjetitelja = new System.Windows.Forms.Label();
            this.lbLokacija = new System.Windows.Forms.Label();
            this.lbPosjecenost = new System.Windows.Forms.ListBox();
            this.btnPrintPosjecenost = new System.Windows.Forms.Button();
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.promjenaJezikaINacijeToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.promjenaNatjecanjaToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.izlazakIzAplikacijeToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.pageSetupDialog = new System.Windows.Forms.PageSetupDialog();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGolovi)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbKartoni)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.menuStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Location = new System.Drawing.Point(-2, 3);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(845, 590);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = global::Windows_Forms_Aplikacija.Properties.Resources.Pocetna_Slika;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.btnPrintGolovi);
            this.tabPage1.Controls.Add(this.lbBrojGolova);
            this.tabPage1.Controls.Add(this.pictureBox2);
            this.tabPage1.Controls.Add(this.lbPrezime);
            this.tabPage1.Controls.Add(this.lbIme);
            this.tabPage1.Controls.Add(this.pbGolovi);
            this.tabPage1.Controls.Add(this.lbgolovi);
            this.tabPage1.Controls.Add(this.lbNaslovGolovi);
            this.tabPage1.Controls.Add(this.menuStrip1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(837, 561);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Broj Golova";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnPrintGolovi
            // 
            this.btnPrintGolovi.BackgroundImage = global::Windows_Forms_Aplikacija.Properties.Resources.print;
            this.btnPrintGolovi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrintGolovi.Location = new System.Drawing.Point(764, 41);
            this.btnPrintGolovi.Name = "btnPrintGolovi";
            this.btnPrintGolovi.Size = new System.Drawing.Size(63, 54);
            this.btnPrintGolovi.TabIndex = 10;
            this.btnPrintGolovi.UseVisualStyleBackColor = true;
            this.btnPrintGolovi.Click += new System.EventHandler(this.BtnPrintGolovi_Click);
            // 
            // lbBrojGolova
            // 
            this.lbBrojGolova.AutoSize = true;
            this.lbBrojGolova.Font = new System.Drawing.Font("Wide Latin", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBrojGolova.Location = new System.Drawing.Point(613, 378);
            this.lbBrojGolova.Name = "lbBrojGolova";
            this.lbBrojGolova.Size = new System.Drawing.Size(71, 50);
            this.lbBrojGolova.TabIndex = 9;
            this.lbBrojGolova.Text = "0";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Windows_Forms_Aplikacija.Properties.Resources.Soccer_Ball_icon;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(692, 378);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(73, 59);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // lbPrezime
            // 
            this.lbPrezime.AutoSize = true;
            this.lbPrezime.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrezime.Location = new System.Drawing.Point(576, 297);
            this.lbPrezime.Name = "lbPrezime";
            this.lbPrezime.Size = new System.Drawing.Size(143, 43);
            this.lbPrezime.TabIndex = 7;
            this.lbPrezime.Text = "Prezime";
            // 
            // lbIme
            // 
            this.lbIme.AutoSize = true;
            this.lbIme.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIme.Location = new System.Drawing.Point(576, 225);
            this.lbIme.Name = "lbIme";
            this.lbIme.Size = new System.Drawing.Size(76, 43);
            this.lbIme.TabIndex = 6;
            this.lbIme.Text = "Ime";
            // 
            // pbGolovi
            // 
            this.pbGolovi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbGolovi.Location = new System.Drawing.Point(319, 169);
            this.pbGolovi.Name = "pbGolovi";
            this.pbGolovi.Size = new System.Drawing.Size(236, 340);
            this.pbGolovi.TabIndex = 5;
            this.pbGolovi.TabStop = false;
            // 
            // lbgolovi
            // 
            this.lbgolovi.BackColor = System.Drawing.Color.LightGreen;
            this.lbgolovi.FormattingEnabled = true;
            this.lbgolovi.ItemHeight = 16;
            this.lbgolovi.Location = new System.Drawing.Point(10, 41);
            this.lbgolovi.Name = "lbgolovi";
            this.lbgolovi.Size = new System.Drawing.Size(282, 468);
            this.lbgolovi.TabIndex = 4;
            this.lbgolovi.SelectedIndexChanged += new System.EventHandler(this.Lbgolovi_SelectedIndexChanged);
            // 
            // lbNaslovGolovi
            // 
            this.lbNaslovGolovi.AutoSize = true;
            this.lbNaslovGolovi.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNaslovGolovi.Location = new System.Drawing.Point(319, 41);
            this.lbNaslovGolovi.Name = "lbNaslovGolovi";
            this.lbNaslovGolovi.Size = new System.Drawing.Size(257, 48);
            this.lbNaslovGolovi.TabIndex = 0;
            this.lbNaslovGolovi.Text = "Najvise Golova";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.PaleGreen;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(3, 3);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(831, 28);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.Color.LightGreen;
            this.toolStripMenuItem1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
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
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = global::Windows_Forms_Aplikacija.Properties.Resources.Pocetna_Slika;
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage2.Controls.Add(this.pictureBox4);
            this.tabPage2.Controls.Add(this.lbBrojKartona);
            this.tabPage2.Controls.Add(this.lbPrezimeKartoni);
            this.tabPage2.Controls.Add(this.lbImeKartoni);
            this.tabPage2.Controls.Add(this.btnPrintKartoni);
            this.tabPage2.Controls.Add(this.pbKartoni);
            this.tabPage2.Controls.Add(this.lbNaslovKartoni);
            this.tabPage2.Controls.Add(this.listaKartoni);
            this.tabPage2.Controls.Add(this.menuStrip2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(837, 561);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Zuti Kartoni";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::Windows_Forms_Aplikacija.Properties.Resources.card;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(678, 376);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(87, 50);
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            // 
            // lbBrojKartona
            // 
            this.lbBrojKartona.AutoSize = true;
            this.lbBrojKartona.Font = new System.Drawing.Font("Wide Latin", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBrojKartona.Location = new System.Drawing.Point(601, 376);
            this.lbBrojKartona.Name = "lbBrojKartona";
            this.lbBrojKartona.Size = new System.Drawing.Size(71, 50);
            this.lbBrojKartona.TabIndex = 10;
            this.lbBrojKartona.Text = "0";
            // 
            // lbPrezimeKartoni
            // 
            this.lbPrezimeKartoni.AutoSize = true;
            this.lbPrezimeKartoni.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrezimeKartoni.Location = new System.Drawing.Point(562, 300);
            this.lbPrezimeKartoni.Name = "lbPrezimeKartoni";
            this.lbPrezimeKartoni.Size = new System.Drawing.Size(245, 43);
            this.lbPrezimeKartoni.TabIndex = 9;
            this.lbPrezimeKartoni.Text = "Prezime Igraca";
            // 
            // lbImeKartoni
            // 
            this.lbImeKartoni.AutoSize = true;
            this.lbImeKartoni.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbImeKartoni.Location = new System.Drawing.Point(562, 229);
            this.lbImeKartoni.Name = "lbImeKartoni";
            this.lbImeKartoni.Size = new System.Drawing.Size(178, 43);
            this.lbImeKartoni.TabIndex = 8;
            this.lbImeKartoni.Text = "Ime Igraca";
            // 
            // btnPrintKartoni
            // 
            this.btnPrintKartoni.BackgroundImage = global::Windows_Forms_Aplikacija.Properties.Resources.print;
            this.btnPrintKartoni.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrintKartoni.Location = new System.Drawing.Point(764, 51);
            this.btnPrintKartoni.Name = "btnPrintKartoni";
            this.btnPrintKartoni.Size = new System.Drawing.Size(67, 55);
            this.btnPrintKartoni.TabIndex = 6;
            this.btnPrintKartoni.UseVisualStyleBackColor = true;
            this.btnPrintKartoni.Click += new System.EventHandler(this.BtnPrintKartoni_Click);
            // 
            // pbKartoni
            // 
            this.pbKartoni.Location = new System.Drawing.Point(305, 178);
            this.pbKartoni.Name = "pbKartoni";
            this.pbKartoni.Size = new System.Drawing.Size(236, 325);
            this.pbKartoni.TabIndex = 3;
            this.pbKartoni.TabStop = false;
            // 
            // lbNaslovKartoni
            // 
            this.lbNaslovKartoni.AutoSize = true;
            this.lbNaslovKartoni.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNaslovKartoni.Location = new System.Drawing.Point(330, 51);
            this.lbNaslovKartoni.Name = "lbNaslovKartoni";
            this.lbNaslovKartoni.Size = new System.Drawing.Size(364, 48);
            this.lbNaslovKartoni.TabIndex = 2;
            this.lbNaslovKartoni.Text = "Najvise Zutih Kartona";
            // 
            // listaKartoni
            // 
            this.listaKartoni.BackColor = System.Drawing.Color.LightGreen;
            this.listaKartoni.FormattingEnabled = true;
            this.listaKartoni.ItemHeight = 16;
            this.listaKartoni.Location = new System.Drawing.Point(10, 51);
            this.listaKartoni.Name = "listaKartoni";
            this.listaKartoni.Size = new System.Drawing.Size(274, 452);
            this.listaKartoni.TabIndex = 0;
            this.listaKartoni.SelectedIndexChanged += new System.EventHandler(this.LbKartoni_SelectedIndexChanged);
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.PaleGreen;
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            this.menuStrip2.Location = new System.Drawing.Point(3, 3);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(831, 28);
            this.menuStrip2.TabIndex = 12;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.BackColor = System.Drawing.Color.LightGreen;
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.promjenaJezikaINacijeToolStripMenuItem1,
            this.promjenaNatjecanjaToolStripMenuItem1,
            this.izlazakIzAplikacijeToolStripMenuItem1});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(80, 24);
            this.toolStripMenuItem2.Text = "Postavke";
            // 
            // promjenaJezikaINacijeToolStripMenuItem1
            // 
            this.promjenaJezikaINacijeToolStripMenuItem1.Name = "promjenaJezikaINacijeToolStripMenuItem1";
            this.promjenaJezikaINacijeToolStripMenuItem1.Size = new System.Drawing.Size(248, 26);
            this.promjenaJezikaINacijeToolStripMenuItem1.Text = "Promjena jezika i nacije";
            this.promjenaJezikaINacijeToolStripMenuItem1.Click += new System.EventHandler(this.PromjenaJezikaINacijeToolStripMenuItem1_Click);
            // 
            // promjenaNatjecanjaToolStripMenuItem1
            // 
            this.promjenaNatjecanjaToolStripMenuItem1.Name = "promjenaNatjecanjaToolStripMenuItem1";
            this.promjenaNatjecanjaToolStripMenuItem1.Size = new System.Drawing.Size(248, 26);
            this.promjenaNatjecanjaToolStripMenuItem1.Text = "Promjena natjecanja";
            this.promjenaNatjecanjaToolStripMenuItem1.Click += new System.EventHandler(this.PromjenaNatjecanjaToolStripMenuItem1_Click);
            // 
            // izlazakIzAplikacijeToolStripMenuItem1
            // 
            this.izlazakIzAplikacijeToolStripMenuItem1.Name = "izlazakIzAplikacijeToolStripMenuItem1";
            this.izlazakIzAplikacijeToolStripMenuItem1.Size = new System.Drawing.Size(248, 26);
            this.izlazakIzAplikacijeToolStripMenuItem1.Text = "Izlazak iz aplikacije";
            this.izlazakIzAplikacijeToolStripMenuItem1.Click += new System.EventHandler(this.IzlazakIzAplikacijeToolStripMenuItem1_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackgroundImage = global::Windows_Forms_Aplikacija.Properties.Resources.Pocetna_Slika;
            this.tabPage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage3.Controls.Add(this.lbNaslovPosjecenost);
            this.tabPage3.Controls.Add(this.lbAwayTeam);
            this.tabPage3.Controls.Add(this.lbHomeTeam);
            this.tabPage3.Controls.Add(this.lbBrojPosjetitelja);
            this.tabPage3.Controls.Add(this.lbLokacija);
            this.tabPage3.Controls.Add(this.lbPosjecenost);
            this.tabPage3.Controls.Add(this.btnPrintPosjecenost);
            this.tabPage3.Controls.Add(this.menuStrip3);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(837, 561);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Posjecenost";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lbNaslovPosjecenost
            // 
            this.lbNaslovPosjecenost.AutoSize = true;
            this.lbNaslovPosjecenost.Font = new System.Drawing.Font("Impact", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNaslovPosjecenost.Location = new System.Drawing.Point(214, 73);
            this.lbNaslovPosjecenost.Name = "lbNaslovPosjecenost";
            this.lbNaslovPosjecenost.Size = new System.Drawing.Size(403, 41);
            this.lbNaslovPosjecenost.TabIndex = 7;
            this.lbNaslovPosjecenost.Text = "Posjecenost Po Utakmicama";
            // 
            // lbAwayTeam
            // 
            this.lbAwayTeam.AutoSize = true;
            this.lbAwayTeam.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAwayTeam.Location = new System.Drawing.Point(502, 400);
            this.lbAwayTeam.Name = "lbAwayTeam";
            this.lbAwayTeam.Size = new System.Drawing.Size(115, 49);
            this.lbAwayTeam.TabIndex = 6;
            this.lbAwayTeam.Text = "Gosti";
            // 
            // lbHomeTeam
            // 
            this.lbHomeTeam.AutoSize = true;
            this.lbHomeTeam.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHomeTeam.Location = new System.Drawing.Point(502, 317);
            this.lbHomeTeam.Name = "lbHomeTeam";
            this.lbHomeTeam.Size = new System.Drawing.Size(155, 49);
            this.lbHomeTeam.TabIndex = 5;
            this.lbHomeTeam.Text = "Domaci";
            // 
            // lbBrojPosjetitelja
            // 
            this.lbBrojPosjetitelja.AutoSize = true;
            this.lbBrojPosjetitelja.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBrojPosjetitelja.Location = new System.Drawing.Point(502, 238);
            this.lbBrojPosjetitelja.Name = "lbBrojPosjetitelja";
            this.lbBrojPosjetitelja.Size = new System.Drawing.Size(44, 49);
            this.lbBrojPosjetitelja.TabIndex = 4;
            this.lbBrojPosjetitelja.Text = "0";
            // 
            // lbLokacija
            // 
            this.lbLokacija.AutoSize = true;
            this.lbLokacija.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLokacija.Location = new System.Drawing.Point(502, 173);
            this.lbLokacija.Name = "lbLokacija";
            this.lbLokacija.Size = new System.Drawing.Size(170, 49);
            this.lbLokacija.TabIndex = 3;
            this.lbLokacija.Text = "Lokacija";
            // 
            // lbPosjecenost
            // 
            this.lbPosjecenost.BackColor = System.Drawing.Color.LightGreen;
            this.lbPosjecenost.FormattingEnabled = true;
            this.lbPosjecenost.ItemHeight = 16;
            this.lbPosjecenost.Location = new System.Drawing.Point(56, 173);
            this.lbPosjecenost.Name = "lbPosjecenost";
            this.lbPosjecenost.Size = new System.Drawing.Size(254, 276);
            this.lbPosjecenost.TabIndex = 2;
            this.lbPosjecenost.SelectedIndexChanged += new System.EventHandler(this.LbPosjecenost_SelectedIndexChanged);
            // 
            // btnPrintPosjecenost
            // 
            this.btnPrintPosjecenost.BackgroundImage = global::Windows_Forms_Aplikacija.Properties.Resources.print;
            this.btnPrintPosjecenost.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrintPosjecenost.Location = new System.Drawing.Point(743, 59);
            this.btnPrintPosjecenost.Name = "btnPrintPosjecenost";
            this.btnPrintPosjecenost.Size = new System.Drawing.Size(69, 55);
            this.btnPrintPosjecenost.TabIndex = 0;
            this.btnPrintPosjecenost.UseVisualStyleBackColor = true;
            this.btnPrintPosjecenost.Click += new System.EventHandler(this.BtnPrintPosjecenost_Click);
            // 
            // menuStrip3
            // 
            this.menuStrip3.BackColor = System.Drawing.Color.PaleGreen;
            this.menuStrip3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3});
            this.menuStrip3.Location = new System.Drawing.Point(3, 3);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.Size = new System.Drawing.Size(831, 28);
            this.menuStrip3.TabIndex = 11;
            this.menuStrip3.Text = "menuStrip3";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.BackColor = System.Drawing.Color.LightGreen;
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.promjenaJezikaINacijeToolStripMenuItem2,
            this.promjenaNatjecanjaToolStripMenuItem2,
            this.izlazakIzAplikacijeToolStripMenuItem2});
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(80, 24);
            this.toolStripMenuItem3.Text = "Postavke";
            // 
            // promjenaJezikaINacijeToolStripMenuItem2
            // 
            this.promjenaJezikaINacijeToolStripMenuItem2.Name = "promjenaJezikaINacijeToolStripMenuItem2";
            this.promjenaJezikaINacijeToolStripMenuItem2.Size = new System.Drawing.Size(248, 26);
            this.promjenaJezikaINacijeToolStripMenuItem2.Text = "Promjena jezika i nacije";
            this.promjenaJezikaINacijeToolStripMenuItem2.Click += new System.EventHandler(this.PromjenaJezikaINacijeToolStripMenuItem2_Click);
            // 
            // promjenaNatjecanjaToolStripMenuItem2
            // 
            this.promjenaNatjecanjaToolStripMenuItem2.Name = "promjenaNatjecanjaToolStripMenuItem2";
            this.promjenaNatjecanjaToolStripMenuItem2.Size = new System.Drawing.Size(248, 26);
            this.promjenaNatjecanjaToolStripMenuItem2.Text = "Promjena natjecanja";
            this.promjenaNatjecanjaToolStripMenuItem2.Click += new System.EventHandler(this.PromjenaNatjecanjaToolStripMenuItem2_Click);
            // 
            // izlazakIzAplikacijeToolStripMenuItem2
            // 
            this.izlazakIzAplikacijeToolStripMenuItem2.Name = "izlazakIzAplikacijeToolStripMenuItem2";
            this.izlazakIzAplikacijeToolStripMenuItem2.Size = new System.Drawing.Size(248, 26);
            this.izlazakIzAplikacijeToolStripMenuItem2.Text = "Izlazak iz aplikacije";
            this.izlazakIzAplikacijeToolStripMenuItem2.Click += new System.EventHandler(this.IzlazakIzAplikacijeToolStripMenuItem2_Click);
            // 
            // printDocument
            // 
            this.printDocument.EndPrint += new System.Drawing.Printing.PrintEventHandler(this.PrintDocument_EndPrint);
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument_PrintPage);
            // 
            // printDialog
            // 
            this.printDialog.Document = this.printDocument;
            this.printDialog.UseEXDialog = true;
            // 
            // pageSetupDialog
            // 
            this.pageSetupDialog.Document = this.printDocument;
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Document = this.printDocument;
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.Name = "printPreviewDialog";
            this.printPreviewDialog.Visible = false;
            // 
            // RangListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(841, 590);
            this.Controls.Add(this.tabControl);
            this.MainMenuStrip = this.menuStrip2;
            this.Name = "RangListe";
            this.Text = "RangListe";
            this.Load += new System.EventHandler(this.RangListe_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGolovi)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbKartoni)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.menuStrip3.ResumeLayout(false);
            this.menuStrip3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbPrezime;
        private System.Windows.Forms.Label lbIme;
        private System.Windows.Forms.PictureBox pbGolovi;
        private System.Windows.Forms.ListBox lbgolovi;
        private System.Windows.Forms.Label lbNaslovGolovi;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label lbBrojGolova;
        private System.Windows.Forms.Button btnPrintGolovi;
        private System.Windows.Forms.ListBox listaKartoni;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lbBrojKartona;
        private System.Windows.Forms.Label lbPrezimeKartoni;
        private System.Windows.Forms.Label lbImeKartoni;
        private System.Windows.Forms.Button btnPrintKartoni;
        private System.Windows.Forms.PictureBox pbKartoni;
        private System.Windows.Forms.Label lbNaslovKartoni;
        private System.Windows.Forms.Button btnPrintPosjecenost;
        private System.Windows.Forms.Label lbNaslovPosjecenost;
        private System.Windows.Forms.Label lbAwayTeam;
        private System.Windows.Forms.Label lbHomeTeam;
        private System.Windows.Forms.Label lbBrojPosjetitelja;
        private System.Windows.Forms.Label lbLokacija;
        private System.Windows.Forms.ListBox lbPosjecenost;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.PrintDialog printDialog;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem promjenaJezikaINacijeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem promjenaNatjecanjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izlazakIzAplikacijeToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem promjenaJezikaINacijeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem promjenaNatjecanjaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem izlazakIzAplikacijeToolStripMenuItem1;
        private System.Windows.Forms.MenuStrip menuStrip3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem promjenaJezikaINacijeToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem promjenaNatjecanjaToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem izlazakIzAplikacijeToolStripMenuItem2;
    }
}