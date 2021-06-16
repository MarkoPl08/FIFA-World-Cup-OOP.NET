using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows_Forms_Aplikacija.Jezici;

namespace Windows_Forms_Aplikacija.Forme
{
    public partial class OmiljeniIgraci : Form
    {
        public OmiljeniIgraci()
        {
            InitializeComponent();
            Init();
            this.Hide();
        }

        private void Init()
        {
            var mojaKontrola = new Windows_Forms_Aplikacija.Kontrole.Omiljeni_Igraci_UserControl();
            panelOmiljeniIgraci.Controls.Add(mojaKontrola);
        }
        private void OmiljeniIgraci_Load(object sender, EventArgs e)
        {
            lbOmiljeni.Text = Moji_Resursi.lbOmiljeni;
            lbSviIgraci.Text = Moji_Resursi.lbSviIgraci;
            btnDalje.Text = Moji_Resursi.btnDalje;
        }

        private void BtnDalje_Click(object sender, EventArgs e)
        {
            new Igraci().Show();
            this.Hide();
        }

        private void PromjenaJezikaINacijeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Postavke().Show();
            this.Hide();
        }

        private void PromjenaNatjecanjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void IzlazakIzAplikacijeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
