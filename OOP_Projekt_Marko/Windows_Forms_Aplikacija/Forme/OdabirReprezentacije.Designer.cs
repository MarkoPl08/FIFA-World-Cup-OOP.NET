namespace Windows_Forms_Aplikacija
{
    partial class OdabirReprezentacije
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
            this.lbOmiljenaRepka = new System.Windows.Forms.Label();
            this.dbOdabirRepki = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbOmiljenaRepka
            // 
            this.lbOmiljenaRepka.AutoSize = true;
            this.lbOmiljenaRepka.BackColor = System.Drawing.Color.PaleGreen;
            this.lbOmiljenaRepka.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOmiljenaRepka.Location = new System.Drawing.Point(82, 36);
            this.lbOmiljenaRepka.Name = "lbOmiljenaRepka";
            this.lbOmiljenaRepka.Size = new System.Drawing.Size(494, 39);
            this.lbOmiljenaRepka.TabIndex = 0;
            this.lbOmiljenaRepka.Text = "Odaberite Omiljenu Reprezentaciju";
            // 
            // dbOdabirRepki
            // 
            this.dbOdabirRepki.FormattingEnabled = true;
            this.dbOdabirRepki.Location = new System.Drawing.Point(178, 134);
            this.dbOdabirRepki.Name = "dbOdabirRepki";
            this.dbOdabirRepki.Size = new System.Drawing.Size(261, 24);
            this.dbOdabirRepki.TabIndex = 1;
            this.dbOdabirRepki.SelectedIndexChanged += new System.EventHandler(this.DbOdabirRepki_SelectedIndexChanged);
            // 
            // OdabirReprezentacije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Windows_Forms_Aplikacija.Properties.Resources.Pocetna_Slika;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(660, 325);
            this.Controls.Add(this.dbOdabirRepki);
            this.Controls.Add(this.lbOmiljenaRepka);
            this.Name = "OdabirReprezentacije";
            this.Text = "OdabirReprezentacije";
            this.Load += new System.EventHandler(this.OdabirReprezentacije_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbOmiljenaRepka;
        private System.Windows.Forms.ComboBox dbOdabirRepki;
    }
}