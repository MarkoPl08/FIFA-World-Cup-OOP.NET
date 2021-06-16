namespace Windows_Forms_Aplikacija.Forme
{
    partial class Postavke
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
            this.dbRepkaOdabir = new System.Windows.Forms.ComboBox();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.lbRepkaOpcije = new System.Windows.Forms.Label();
            this.lbJezikOpcije = new System.Windows.Forms.Label();
            this.btnPrijevodOpcije = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dbRepkaOdabir
            // 
            this.dbRepkaOdabir.BackColor = System.Drawing.Color.PaleGreen;
            this.dbRepkaOdabir.FormattingEnabled = true;
            this.dbRepkaOdabir.Location = new System.Drawing.Point(26, 88);
            this.dbRepkaOdabir.Name = "dbRepkaOdabir";
            this.dbRepkaOdabir.Size = new System.Drawing.Size(178, 24);
            this.dbRepkaOdabir.TabIndex = 0;
            this.dbRepkaOdabir.SelectedIndexChanged += new System.EventHandler(this.DbRepkaOdabir_SelectedIndexChanged);
            // 
            // btnSpremi
            // 
            this.btnSpremi.BackColor = System.Drawing.Color.LightGreen;
            this.btnSpremi.Location = new System.Drawing.Point(212, 155);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(100, 31);
            this.btnSpremi.TabIndex = 1;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = false;
            this.btnSpremi.Click += new System.EventHandler(this.BtnSpremi_Click);
            // 
            // lbRepkaOpcije
            // 
            this.lbRepkaOpcije.AutoSize = true;
            this.lbRepkaOpcije.BackColor = System.Drawing.Color.Transparent;
            this.lbRepkaOpcije.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRepkaOpcije.Location = new System.Drawing.Point(22, 36);
            this.lbRepkaOpcije.Name = "lbRepkaOpcije";
            this.lbRepkaOpcije.Size = new System.Drawing.Size(206, 22);
            this.lbRepkaOpcije.TabIndex = 2;
            this.lbRepkaOpcije.Text = "Omiljena Reprezentacija";
            // 
            // lbJezikOpcije
            // 
            this.lbJezikOpcije.AutoSize = true;
            this.lbJezikOpcije.BackColor = System.Drawing.Color.Transparent;
            this.lbJezikOpcije.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbJezikOpcije.Location = new System.Drawing.Point(312, 36);
            this.lbJezikOpcije.Name = "lbJezikOpcije";
            this.lbJezikOpcije.Size = new System.Drawing.Size(138, 22);
            this.lbJezikOpcije.TabIndex = 3;
            this.lbJezikOpcije.Text = "Jezik Aplikacije";
            // 
            // btnPrijevodOpcije
            // 
            this.btnPrijevodOpcije.BackColor = System.Drawing.Color.PaleGreen;
            this.btnPrijevodOpcije.Location = new System.Drawing.Point(335, 74);
            this.btnPrijevodOpcije.Name = "btnPrijevodOpcije";
            this.btnPrijevodOpcije.Size = new System.Drawing.Size(86, 50);
            this.btnPrijevodOpcije.TabIndex = 4;
            this.btnPrijevodOpcije.Text = "HR";
            this.btnPrijevodOpcije.UseVisualStyleBackColor = false;
            this.btnPrijevodOpcije.Click += new System.EventHandler(this.BtnPrijevodOpcije_Click);
            // 
            // Postavke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Windows_Forms_Aplikacija.Properties.Resources.Pocetna_Slika;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(502, 218);
            this.Controls.Add(this.btnPrijevodOpcije);
            this.Controls.Add(this.lbJezikOpcije);
            this.Controls.Add(this.lbRepkaOpcije);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.dbRepkaOdabir);
            this.Name = "Postavke";
            this.Text = "Postavke";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox dbRepkaOdabir;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Label lbRepkaOpcije;
        private System.Windows.Forms.Label lbJezikOpcije;
        private System.Windows.Forms.Button btnPrijevodOpcije;
    }
}