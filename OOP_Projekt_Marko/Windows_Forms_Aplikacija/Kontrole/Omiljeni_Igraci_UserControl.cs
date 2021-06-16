using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Podatkovni_Sloj;
using System.IO;
using QuickType;
using Windows_Forms_Aplikacija.Forme;
using Windows_Forms_Aplikacija.Jezici;

namespace Windows_Forms_Aplikacija.Kontrole
{
    public partial class Omiljeni_Igraci_UserControl : UserControl
    {
       
        public Omiljeni_Igraci_UserControl()
        {                    
            InitializeComponent();
        }
        private void Omiljeni_Igraci_UserControl_Load(object sender, EventArgs e)
        {
            Prijevod();
            LoadData();
        }

        private void Prijevod()
        {
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

            List<StartingEleven> igraci = new List<StartingEleven>();

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
                SviIgraci.Items.Add(Igrac);
            }


        }
        private void SviIgraci_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void OmiljeniIgraci_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void OmiljeniIgraci_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;

            if (OmiljeniIgraci.Items.Count < 3)
            {

                OmiljeniIgraci.Items.Add(e.Data.GetData(DataFormats.Text));
                SviIgraci.Items.Remove(e.Data.GetData(DataFormats.Text));

            }
            else
            {
                return;
            }
        }

        private void SviIgraci_MouseDown(object sender, MouseEventArgs e)
        {
            SviIgraci.SelectedItem.ToString();

            OmiljeniIgraci.DoDragDrop(SviIgraci.Text, DragDropEffects.Move);


        }

        //private void OmiljeniIgraci_MouseDown(object sender, MouseEventArgs e)
        //{
        //    OmiljeniIgraci.SelectedItem.ToString();

        //    SviIgraci.DoDragDrop(OmiljeniIgraci.Text, DragDropEffects.Move);
        //}

        //private void SviIgraci_DragEnter(object sender, DragEventArgs e)
        //{
        //    e.Effect = DragDropEffects.Move;

        //    SviIgraci.Items.Add(e.Data.GetData(DataFormats.Text));
        //    OmiljeniIgraci.Items.Remove(e.Data.GetData(DataFormats.Text));
        //}

        private void BtnPosaljiJednogIgraca_Click(object sender, EventArgs e)
        {
            var odabrani = SviIgraci.SelectedItem;

            if (odabrani == null)
            {
                return;
            }
            if (OmiljeniIgraci.Items.Count < 3)
            {
                OmiljeniIgraci.Items.Add(odabrani);
                SviIgraci.Items.Remove(odabrani);

            }
        }

        private void BtnVratiJednogIgraca_Click(object sender, EventArgs e)
        {
            var odabrani = OmiljeniIgraci.SelectedItem;

            if (odabrani == null)
            {
                return;
            }
            OmiljeniIgraci.Items.Remove(odabrani);
            SviIgraci.Items.Add(odabrani);
        }
        private void BtnPosaljiSveIgrace_Click(object sender, EventArgs e)
        {
            while (SviIgraci.SelectedItems.Count != 0)
            {
                if (OmiljeniIgraci.Items.Count <3)
                {
                    OmiljeniIgraci.Items.Add(SviIgraci.SelectedItems[0]);
                    SviIgraci.Items.Remove(SviIgraci.SelectedItems[0]);
                }
                else
                {
                    return;
                }
            }
        }

        private void BtnVratiSveIgrace_Click(object sender, EventArgs e)
        {
            while (OmiljeniIgraci.SelectedItems.Count != 0)
            {                
                 SviIgraci.Items.Add(OmiljeniIgraci.SelectedItems[0]);
                 OmiljeniIgraci.Items.Remove(OmiljeniIgraci.SelectedItems[0]);                              
            }
        }

        private void BtnSpremi_Click(object sender, EventArgs e)
        {
            string path = @"..\..\..\..\Omiljeni_Igraci.txt";

            StreamWriter SaveFile = new StreamWriter(path);
            foreach (var item in OmiljeniIgraci.Items)
            {
                SaveFile.WriteLine(item);
            }
            SaveFile.ToString();
            SaveFile.Close();
            MessageBox.Show("Uspješno spremljeno", "Spremljeno", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        
    }
}
