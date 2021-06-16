using Podatkovni_Sloj;
using QuickType;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows_Forms_Aplikacija.Jezici;

namespace Windows_Forms_Aplikacija.Forme
{
    public partial class Igraci : Form
    {
        readonly List<StartingEleven> igraci = new List<StartingEleven>();
        public Igraci()
        {
            InitializeComponent();            
        }
        private void Igraci_Load(object sender, EventArgs e)
        {
            LoadData();
            Prijevod();
        }

        private void Prijevod()
        {
            lbIme.Text = Moji_Resursi.lbIme;
            lbPrezime.Text = Moji_Resursi.lbPrezime;
            btnDalje.Text = Moji_Resursi.btnDalje;
            btnUcitajSliku.Text = Moji_Resursi.btnUcitajSliku;
            btnSpremi.Text = Moji_Resursi.btnSpremi;
        }

        private async void LoadData()
        {
            GetData getData = new Podatkovni_Sloj.GetData();

            string[] lines = File.ReadAllLines(Path.Combine(Environment.CurrentDirectory, @"..\..\..\..\Omiljena_Reprezentacija.txt"));
            string line = lines[0];
            string[] parts = line.Split(' ');
            string drzava = parts[0];
            var Utakmice = await getData.GetUtakmice();

            for (int i = 0; i < 16; i++)
            {
                if (Utakmice[i].AwayTeamCountry == drzava)
                {
                    for (int j = 0; j < Utakmice[i].AwayTeamStatistics.StartingEleven.Count; j++)
                    {
                        igraci.Add(Utakmice[i].AwayTeamStatistics.StartingEleven[j]);
                    }
                    for (int j = 0; j < Utakmice[i].AwayTeamStatistics.Substitutes.Count; j++)
                    {
                        igraci.Add(Utakmice[i].AwayTeamStatistics.Substitutes[j]);
                    }
                }
                else if (Utakmice[i].HomeTeamCountry == drzava)
                {
                    for (int j = 0; j < Utakmice[i].HomeTeamStatistics.StartingEleven.Count; j++)
                    {
                        igraci.Add(Utakmice[i].HomeTeamStatistics.StartingEleven[j]);
                    }
                    for (int j = 0; j < Utakmice[i].HomeTeamStatistics.Substitutes.Count; j++)
                    {
                        igraci.Add(Utakmice[i].HomeTeamStatistics.Substitutes[j]);
                    }
                }

            }
            foreach (var Igrac in igraci)
            {
                listaIgraca.Items.Add(Igrac);
            }
        }
        private void ListaIgraca_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbOmiljeni.Text = " ";
            string lines = listaIgraca.SelectedItem.ToString();
            string[] parts = lines.Split(' ');
            if (parts.Length == 5)
            {
                tbIme.Text = parts[0];
                tbPrezime.Text = parts[1];                
            }
            else if (parts.Length == 6)
            {
                tbIme.Text = parts[0];
                tbPrezime.Text = parts[1] + " " + parts[2];
            }
            else
            {
                tbIme.Text = parts[0];
                tbPrezime.Text = "";
            }
            if (File.Exists(Path.Combine(Environment.CurrentDirectory, @"..\..\..\..\Slike_Igraca\", listaIgraca.SelectedItem.ToString())))
            {
                pbSlikaIgraca.Image = Image.FromFile(Path.Combine(Environment.CurrentDirectory, @"..\..\..\..\Slike_Igraca\", listaIgraca.SelectedItem.ToString()));
            }
            else
            {
                pbSlikaIgraca.Image = Windows_Forms_Aplikacija.Properties.Resources.default_image;
            }
            string[] linije = File.ReadAllLines(Path.Combine(Environment.CurrentDirectory, @"..\..\..\..\Omiljeni_Igraci.txt"));
            if (linije.Contains(listaIgraca.SelectedItem.ToString()))
            {
                lbOmiljeni.Text = "🌟";
            }
        }
        private void BtnUcitajSliku_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog
            {
                Filter = "Image Files(*.jpg; *.jpeg; *.png;)|*.jpg; *.jpeg; *.png"
            };
            if (open.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    tbSpremanje.Text = open.FileName;
                    pbSlikaIgraca.Image = new Bitmap(open.FileName);
                }
                catch (Exception)
                {

                    MessageBox.Show("Greska", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            try
            {
                File.Copy(tbSpremanje.Text, Path.Combine(Environment.CurrentDirectory, @"..\..\..\..\Slike_Igraca\", listaIgraca.SelectedItem.ToString()), true);
            }
            catch (Exception)
            {
                return;
            }
            
        }
        private void BtnSpremi_Click(object sender, EventArgs e)
        {
            File.Copy(tbSpremanje.Text, Path.Combine(@"..\..\..\..\Slike_Igraca\", Path.GetFileName(tbSpremanje.Text)), true);
            MessageBox.Show("Uspjesno spremanje", "Uspjesno", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnDalje_Click(object sender, EventArgs e)
        {
            new RangListe(igraci).Show();
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
