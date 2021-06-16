namespace Windows_Forms_Aplikacija.Kontrole
{
    partial class Omiljeni_Igraci_UserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SviIgraci = new System.Windows.Forms.ListBox();
            this.OmiljeniIgraci = new System.Windows.Forms.ListBox();
            this.btnPosaljiJednogIgraca = new System.Windows.Forms.Button();
            this.btnVratiJednogIgraca = new System.Windows.Forms.Button();
            this.btnPosaljiSveIgrace = new System.Windows.Forms.Button();
            this.btnVratiSveIgrace = new System.Windows.Forms.Button();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SviIgraci
            // 
            this.SviIgraci.AllowDrop = true;
            this.SviIgraci.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.SviIgraci.FormattingEnabled = true;
            this.SviIgraci.ItemHeight = 16;
            this.SviIgraci.Location = new System.Drawing.Point(21, 30);
            this.SviIgraci.Name = "SviIgraci";
            this.SviIgraci.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.SviIgraci.Size = new System.Drawing.Size(265, 436);
            this.SviIgraci.Sorted = true;
            this.SviIgraci.TabIndex = 0;
            this.SviIgraci.SelectedIndexChanged += new System.EventHandler(this.SviIgraci_SelectedIndexChanged);
            this.SviIgraci.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SviIgraci_MouseDown);
            // 
            // OmiljeniIgraci
            // 
            this.OmiljeniIgraci.AllowDrop = true;
            this.OmiljeniIgraci.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.OmiljeniIgraci.FormattingEnabled = true;
            this.OmiljeniIgraci.ItemHeight = 16;
            this.OmiljeniIgraci.Location = new System.Drawing.Point(514, 30);
            this.OmiljeniIgraci.Name = "OmiljeniIgraci";
            this.OmiljeniIgraci.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.OmiljeniIgraci.Size = new System.Drawing.Size(261, 436);
            this.OmiljeniIgraci.Sorted = true;
            this.OmiljeniIgraci.TabIndex = 1;
            this.OmiljeniIgraci.DragEnter += new System.Windows.Forms.DragEventHandler(this.OmiljeniIgraci_DragEnter);
            // 
            // btnPosaljiJednogIgraca
            // 
            this.btnPosaljiJednogIgraca.BackColor = System.Drawing.Color.PaleGreen;
            this.btnPosaljiJednogIgraca.Location = new System.Drawing.Point(343, 30);
            this.btnPosaljiJednogIgraca.Name = "btnPosaljiJednogIgraca";
            this.btnPosaljiJednogIgraca.Size = new System.Drawing.Size(114, 34);
            this.btnPosaljiJednogIgraca.TabIndex = 2;
            this.btnPosaljiJednogIgraca.Text = ">";
            this.btnPosaljiJednogIgraca.UseVisualStyleBackColor = false;
            this.btnPosaljiJednogIgraca.Click += new System.EventHandler(this.BtnPosaljiJednogIgraca_Click);
            // 
            // btnVratiJednogIgraca
            // 
            this.btnVratiJednogIgraca.BackColor = System.Drawing.Color.PaleGreen;
            this.btnVratiJednogIgraca.Location = new System.Drawing.Point(343, 432);
            this.btnVratiJednogIgraca.Name = "btnVratiJednogIgraca";
            this.btnVratiJednogIgraca.Size = new System.Drawing.Size(114, 34);
            this.btnVratiJednogIgraca.TabIndex = 3;
            this.btnVratiJednogIgraca.Text = "<";
            this.btnVratiJednogIgraca.UseVisualStyleBackColor = false;
            this.btnVratiJednogIgraca.Click += new System.EventHandler(this.BtnVratiJednogIgraca_Click);
            // 
            // btnPosaljiSveIgrace
            // 
            this.btnPosaljiSveIgrace.BackColor = System.Drawing.Color.PaleGreen;
            this.btnPosaljiSveIgrace.Location = new System.Drawing.Point(327, 111);
            this.btnPosaljiSveIgrace.Name = "btnPosaljiSveIgrace";
            this.btnPosaljiSveIgrace.Size = new System.Drawing.Size(142, 50);
            this.btnPosaljiSveIgrace.TabIndex = 4;
            this.btnPosaljiSveIgrace.Text = ">>";
            this.btnPosaljiSveIgrace.UseVisualStyleBackColor = false;
            this.btnPosaljiSveIgrace.Click += new System.EventHandler(this.BtnPosaljiSveIgrace_Click);
            // 
            // btnVratiSveIgrace
            // 
            this.btnVratiSveIgrace.BackColor = System.Drawing.Color.PaleGreen;
            this.btnVratiSveIgrace.Location = new System.Drawing.Point(327, 338);
            this.btnVratiSveIgrace.Name = "btnVratiSveIgrace";
            this.btnVratiSveIgrace.Size = new System.Drawing.Size(142, 50);
            this.btnVratiSveIgrace.TabIndex = 5;
            this.btnVratiSveIgrace.Text = "<<";
            this.btnVratiSveIgrace.UseVisualStyleBackColor = false;
            this.btnVratiSveIgrace.Click += new System.EventHandler(this.BtnVratiSveIgrace_Click);
            // 
            // btnSpremi
            // 
            this.btnSpremi.AutoSize = true;
            this.btnSpremi.BackColor = System.Drawing.Color.PaleGreen;
            this.btnSpremi.Location = new System.Drawing.Point(307, 219);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(182, 59);
            this.btnSpremi.TabIndex = 6;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = false;
            this.btnSpremi.Click += new System.EventHandler(this.BtnSpremi_Click);
            // 
            // Omiljeni_Igraci_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Windows_Forms_Aplikacija.Properties.Resources.stadion;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.btnVratiSveIgrace);
            this.Controls.Add(this.btnPosaljiSveIgrace);
            this.Controls.Add(this.btnVratiJednogIgraca);
            this.Controls.Add(this.btnPosaljiJednogIgraca);
            this.Controls.Add(this.OmiljeniIgraci);
            this.Controls.Add(this.SviIgraci);
            this.Name = "Omiljeni_Igraci_UserControl";
            this.Size = new System.Drawing.Size(800, 500);
            this.Load += new System.EventHandler(this.Omiljeni_Igraci_UserControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox SviIgraci;
        private System.Windows.Forms.ListBox OmiljeniIgraci;
        private System.Windows.Forms.Button btnPosaljiJednogIgraca;
        private System.Windows.Forms.Button btnVratiJednogIgraca;
        private System.Windows.Forms.Button btnPosaljiSveIgrace;
        private System.Windows.Forms.Button btnVratiSveIgrace;
        private System.Windows.Forms.Button btnSpremi;
    }
}
