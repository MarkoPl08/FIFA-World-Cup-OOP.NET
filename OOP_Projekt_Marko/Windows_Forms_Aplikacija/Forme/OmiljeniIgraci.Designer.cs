namespace Windows_Forms_Aplikacija.Forme
{
    partial class OmiljeniIgraci
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
            this.panelOmiljeniIgraci = new System.Windows.Forms.Panel();
            this.lbOmiljeni = new System.Windows.Forms.Label();
            this.lbSviIgraci = new System.Windows.Forms.Label();
            this.btnDalje = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.promjenaJezikaINacijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.promjenaNatjecanjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izlazakIzAplikacijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelOmiljeniIgraci
            // 
            this.panelOmiljeniIgraci.Location = new System.Drawing.Point(26, 74);
            this.panelOmiljeniIgraci.Name = "panelOmiljeniIgraci";
            this.panelOmiljeniIgraci.Size = new System.Drawing.Size(791, 491);
            this.panelOmiljeniIgraci.TabIndex = 0;
            // 
            // lbOmiljeni
            // 
            this.lbOmiljeni.AutoSize = true;
            this.lbOmiljeni.BackColor = System.Drawing.Color.PaleGreen;
            this.lbOmiljeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOmiljeni.Location = new System.Drawing.Point(637, 42);
            this.lbOmiljeni.Name = "lbOmiljeni";
            this.lbOmiljeni.Size = new System.Drawing.Size(131, 20);
            this.lbOmiljeni.TabIndex = 1;
            this.lbOmiljeni.Text = "Omiljeni igraci";
            // 
            // lbSviIgraci
            // 
            this.lbSviIgraci.AutoSize = true;
            this.lbSviIgraci.BackColor = System.Drawing.Color.PaleGreen;
            this.lbSviIgraci.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSviIgraci.Location = new System.Drawing.Point(83, 42);
            this.lbSviIgraci.Name = "lbSviIgraci";
            this.lbSviIgraci.Size = new System.Drawing.Size(114, 20);
            this.lbSviIgraci.TabIndex = 2;
            this.lbSviIgraci.Text = "Popis Igraca";
            // 
            // btnDalje
            // 
            this.btnDalje.BackColor = System.Drawing.Color.PaleGreen;
            this.btnDalje.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDalje.ForeColor = System.Drawing.Color.DarkRed;
            this.btnDalje.Location = new System.Drawing.Point(731, 571);
            this.btnDalje.Name = "btnDalje";
            this.btnDalje.Size = new System.Drawing.Size(86, 33);
            this.btnDalje.TabIndex = 3;
            this.btnDalje.Text = "Dalje";
            this.btnDalje.UseVisualStyleBackColor = false;
            this.btnDalje.Click += new System.EventHandler(this.BtnDalje_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.PaleGreen;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(840, 28);
            this.menuStrip1.TabIndex = 4;
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
            // OmiljeniIgraci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Windows_Forms_Aplikacija.Properties.Resources.stadion;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(840, 616);
            this.Controls.Add(this.btnDalje);
            this.Controls.Add(this.lbSviIgraci);
            this.Controls.Add(this.lbOmiljeni);
            this.Controls.Add(this.panelOmiljeniIgraci);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "OmiljeniIgraci";
            this.Text = "OmiljeniIgraci";
            this.Load += new System.EventHandler(this.OmiljeniIgraci_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelOmiljeniIgraci;
        private System.Windows.Forms.Label lbOmiljeni;
        private System.Windows.Forms.Label lbSviIgraci;
        private System.Windows.Forms.Button btnDalje;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem promjenaJezikaINacijeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem promjenaNatjecanjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izlazakIzAplikacijeToolStripMenuItem;
    }
}