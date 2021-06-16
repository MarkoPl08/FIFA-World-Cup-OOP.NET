namespace Windows_Forms_Aplikacija
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
            this.pbMuskoPrvenstvo = new System.Windows.Forms.PictureBox();
            this.pbZenskoPrvenstvo = new System.Windows.Forms.PictureBox();
            this.lbOdabir = new System.Windows.Forms.Label();
            this.btnPrijevod = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbMuskoPrvenstvo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbZenskoPrvenstvo)).BeginInit();
            this.SuspendLayout();
            // 
            // pbMuskoPrvenstvo
            // 
            this.pbMuskoPrvenstvo.Image = global::Windows_Forms_Aplikacija.Properties.Resources.soccer_luka_modric_croatian_luka_modric_wallpaper_preview;
            this.pbMuskoPrvenstvo.Location = new System.Drawing.Point(12, 98);
            this.pbMuskoPrvenstvo.Name = "pbMuskoPrvenstvo";
            this.pbMuskoPrvenstvo.Size = new System.Drawing.Size(391, 250);
            this.pbMuskoPrvenstvo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMuskoPrvenstvo.TabIndex = 1;
            this.pbMuskoPrvenstvo.TabStop = false;
            this.pbMuskoPrvenstvo.Tag = "men";
            this.pbMuskoPrvenstvo.Click += new System.EventHandler(this.PbMuskoPrvenstvo_Click);
            // 
            // pbZenskoPrvenstvo
            // 
            this.pbZenskoPrvenstvo.Image = global::Windows_Forms_Aplikacija.Properties.Resources.Pocetna_Slika_Zenski;
            this.pbZenskoPrvenstvo.Location = new System.Drawing.Point(570, 98);
            this.pbZenskoPrvenstvo.Name = "pbZenskoPrvenstvo";
            this.pbZenskoPrvenstvo.Size = new System.Drawing.Size(400, 250);
            this.pbZenskoPrvenstvo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbZenskoPrvenstvo.TabIndex = 2;
            this.pbZenskoPrvenstvo.TabStop = false;
            this.pbZenskoPrvenstvo.Tag = "women";
            this.pbZenskoPrvenstvo.Click += new System.EventHandler(this.PbZenskoPrvenstvo_Click);
            // 
            // lbOdabir
            // 
            this.lbOdabir.BackColor = System.Drawing.Color.PaleGreen;
            this.lbOdabir.Font = new System.Drawing.Font("Bodoni MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOdabir.Location = new System.Drawing.Point(376, 29);
            this.lbOdabir.Name = "lbOdabir";
            this.lbOdabir.Size = new System.Drawing.Size(238, 54);
            this.lbOdabir.TabIndex = 3;
            this.lbOdabir.Text = "Odabir Prvenstva";
            this.lbOdabir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPrijevod
            // 
            this.btnPrijevod.BackColor = System.Drawing.Color.PaleGreen;
            this.btnPrijevod.Font = new System.Drawing.Font("Bodoni MT", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrijevod.Location = new System.Drawing.Point(447, 305);
            this.btnPrijevod.Name = "btnPrijevod";
            this.btnPrijevod.Size = new System.Drawing.Size(85, 43);
            this.btnPrijevod.TabIndex = 4;
            this.btnPrijevod.Text = "HR";
            this.btnPrijevod.UseVisualStyleBackColor = false;
            this.btnPrijevod.Click += new System.EventHandler(this.BtnPrijevod_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Windows_Forms_Aplikacija.Properties.Resources.Pocetna_Slika;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(982, 453);
            this.Controls.Add(this.btnPrijevod);
            this.Controls.Add(this.lbOdabir);
            this.Controls.Add(this.pbZenskoPrvenstvo);
            this.Controls.Add(this.pbMuskoPrvenstvo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbMuskoPrvenstvo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbZenskoPrvenstvo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pbMuskoPrvenstvo;
        private System.Windows.Forms.PictureBox pbZenskoPrvenstvo;
        private System.Windows.Forms.Label lbOdabir;
        private System.Windows.Forms.Button btnPrijevod;
    }
}

