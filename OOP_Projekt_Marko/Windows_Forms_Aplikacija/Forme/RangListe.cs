using Podatkovni_Sloj;
using QuickType;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows_Forms_Aplikacija.Jezici;
using Windows_Forms_Aplikacija.Models;

namespace Windows_Forms_Aplikacija.Forme
{
    public partial class RangListe : Form
    {
        readonly Dictionary<StartingEleven, int> golovi = new Dictionary<StartingEleven, int>();
        readonly Dictionary<StartingEleven, int> kartoni = new Dictionary<StartingEleven, int>();

        public RangListe(List<StartingEleven> lista)
        {
            InitializeComponent();
            List<StartingEleven> igraci = lista;
            LoadData(igraci);
        }
        private void RangListe_Load(object sender, EventArgs e)
        {
            Prijevod();
        }

        private void Prijevod()
        {
            lbIme.Text = Moji_Resursi.lbIme;
            lbPrezime.Text = Moji_Resursi.lbPrezime;
            lbImeKartoni.Text = Moji_Resursi.lbImeKartoni;
            lbPrezimeKartoni.Text = Moji_Resursi.lbPrezimeKartoni;
            lbLokacija.Text = Moji_Resursi.lbLokacija;
            lbHomeTeam.Text = Moji_Resursi.lbHomeTeam;
            lbAwayTeam.Text = Moji_Resursi.lbAwayTeam;
            lbNaslovGolovi.Text = Moji_Resursi.lbNaslovGolovi;
            lbNaslovKartoni.Text = Moji_Resursi.lbNaslovKartoni;
            lbNaslovPosjecenost.Text = Moji_Resursi.lbNaslovPosjecenost;
        }

        private async void LoadData(List<StartingEleven> igraci)
        {
            GetData getData = new Podatkovni_Sloj.GetData();
            var timovi = await getData.GetUtakmice();

            int gol = 0;
            int zuti = 0;

            foreach (var igrac in igraci)
            {
                for (int i = 0; i < timovi.Count(); i++)
                {
                    for (int j = 0; j < timovi[i].HomeTeamEvents.Count(); j++)
                    {
                        if (timovi[i].HomeTeamEvents[j].TypeOfEvent == TypeOfEvent.Goal || timovi[i].HomeTeamEvents[j].TypeOfEvent == TypeOfEvent.GoalPenalty)
                        {
                            if (timovi[i].HomeTeamEvents[j].Player == igrac.Name)
                            {
                                gol++;
                            }
                        }
                    }
                    for (int j = 0; j < timovi[i].AwayTeamEvents.Count(); j++)
                    {
                        if (timovi[i].AwayTeamEvents[j].TypeOfEvent == TypeOfEvent.Goal || timovi[i].AwayTeamEvents[j].TypeOfEvent == TypeOfEvent.GoalPenalty)
                        {
                            if (timovi[i].AwayTeamEvents[j].Player == igrac.Name)
                            {
                                gol++;
                            }
                        }
                    }
                }
                golovi.Add(igrac, gol);
                gol = 0;
            }
            SortiranjeGolovi();

            foreach (var igrac in igraci)
            {
                for (int i = 0; i < timovi.Count(); i++)
                {
                    for (int j = 0; j < timovi[i].HomeTeamEvents.Count(); j++)
                    {
                        if (timovi[i].HomeTeamEvents[j].TypeOfEvent == TypeOfEvent.YellowCard || timovi[i].HomeTeamEvents[j].TypeOfEvent == TypeOfEvent.YellowCardSecond)
                        {
                            if (timovi[i].HomeTeamEvents[j].Player == igrac.Name)
                            {
                                zuti++;
                            }
                        }
                    }
                    for (int j = 0; j < timovi[i].AwayTeamEvents.Count(); j++)
                    {
                        if (timovi[i].AwayTeamEvents[j].TypeOfEvent == TypeOfEvent.YellowCard || timovi[i].AwayTeamEvents[j].TypeOfEvent == TypeOfEvent.YellowCardSecond)
                        {
                            if (timovi[i].AwayTeamEvents[j].Player == igrac.Name)
                            {
                                zuti++;
                            }
                        }
                    }
                }
                kartoni.Add(igrac, zuti);
                zuti = 0;
            }
            SortiranjeZuti();

            List<Posjecenost> posjecenosts = new List<Posjecenost>();
            string[] lines = File.ReadAllLines(Path.Combine(Environment.CurrentDirectory, @"..\..\..\..\Omiljena_Reprezentacija.txt"));
            string line = lines[0];
            string[] parts = line.Split(' ');
            string country = parts[0];
            foreach (var utakmica in timovi)
            {
                if (utakmica.HomeTeamCountry == country || utakmica.AwayTeamCountry == country)
                {
                    Posjecenost p = new Posjecenost
                    {
                        Attendance = utakmica.Attendance.Value,
                        Venue = utakmica.Venue,
                        Home_team_country = utakmica.HomeTeamCountry,
                        Away_team_country = utakmica.AwayTeamCountry
                    };
                    posjecenosts.Add(p);
                }
            }
            posjecenosts.Sort();
            foreach (var utakmica in posjecenosts)
            {
                lbPosjecenost.Items.Add(utakmica);
            }
        }
        private void SortiranjeGolovi()
        {
            var sortedDict = from entry in golovi orderby entry.Value descending select entry;
            foreach (var igrac in sortedDict)
            {
                lbgolovi.Items.Add(igrac);
            }
        }

        private void SortiranjeZuti()
        {
            var sortedDict = from entry in kartoni orderby entry.Value descending select entry;
            foreach (var igrac in sortedDict)
            {
                listaKartoni.Items.Add(igrac);
            }
        }

        private void Lbgolovi_SelectedIndexChanged(object sender, EventArgs e)
        {
            string lines = lbgolovi.SelectedItem.ToString();
            string[] parts = lines.Split(' ');
            if (parts.Length == 6)
            {
                lbIme.Text = parts[0].TrimStart('[');
                lbPrezime.Text = parts[1];
                lbBrojGolova.Text = parts[5].TrimEnd(']');

            }
            else if (parts.Length == 7)
            {
                lbIme.Text = parts[0].TrimStart('[');
                lbPrezime.Text = parts[1] + " " + parts[2];
                lbBrojGolova.Text = parts[6].TrimEnd(']');
            }
            else
            {
                lbIme.Text = parts[0].TrimStart('[');
                lbPrezime.Text = "";
                lbBrojGolova.Text = parts[4].TrimEnd(']');
            }
            if (File.Exists(Path.Combine(Environment.CurrentDirectory, @"..\..\..\..\Slike_Igraca\", lbgolovi.SelectedItem.ToString())))
            {
                pbGolovi.Image = Image.FromFile(Path.Combine(Environment.CurrentDirectory, @"..\..\..\..\Slike_Igraca\", lbgolovi.SelectedItem.ToString()));
            }
            else
            {
                pbGolovi.Image = Windows_Forms_Aplikacija.Properties.Resources.default_image;
            }
        }

        private void LbKartoni_SelectedIndexChanged(object sender, EventArgs e)
        {
            string lines = listaKartoni.SelectedItem.ToString();
            string[] parts = lines.Split(' ');
            if (parts.Length == 6)
            {
                lbImeKartoni.Text = parts[0].TrimStart('[');
                lbPrezimeKartoni.Text = parts[1];
                lbBrojKartona.Text = parts[5].TrimEnd(']');
            }
            else if (parts.Length == 7)
            {
                lbImeKartoni.Text = parts[0].TrimStart('[');
                lbPrezimeKartoni.Text = parts[1] + " " + parts[2];
                lbBrojKartona.Text = parts[6].TrimEnd(']');

            }
            else
            {
                lbImeKartoni.Text = parts[0].TrimStart('[');
                lbPrezimeKartoni.Text = "";
                lbBrojKartona.Text = parts[4].TrimEnd(']');
            }
            if (File.Exists(Path.Combine(Environment.CurrentDirectory, @"..\..\..\..\Slike_Igraca\", listaKartoni.SelectedItem.ToString())))
            {
                pbKartoni.Image = Image.FromFile(Path.Combine(Environment.CurrentDirectory, @"..\..\..\..\Slike_Igraca\", listaKartoni.SelectedItem.ToString()));
            }
            else
            {
                pbKartoni.Image = Windows_Forms_Aplikacija.Properties.Resources.default_image;
            }
        }

        private void LbPosjecenost_SelectedIndexChanged(object sender, EventArgs e)
        {
            Posjecenost posjecenost = lbPosjecenost.SelectedItem as Posjecenost;
            lbLokacija.Text = posjecenost.Venue;
            lbBrojPosjetitelja.Text = posjecenost.Attendance.ToString();
            lbHomeTeam.Text = posjecenost.Home_team_country;
            lbAwayTeam.Text = posjecenost.Away_team_country;
        }

        private StringReader myReader;
        private void PrintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Najbolji_Strijelci(e);
            Najvise_Kartona(e);
            Posjecenost(e);
        }

        private void Najbolji_Strijelci(PrintPageEventArgs e)
        {
            int count = 0;
            float leftMargin = e.MarginBounds.Left;
            float topMargin = e.MarginBounds.Top;
            string line = null;
            Font printFont = this.lbgolovi.Font;
            SolidBrush myBrush = new SolidBrush(Color.Black);

            float linesPerPage = e.MarginBounds.Height / printFont.GetHeight(e.Graphics);

            while (count < linesPerPage && ((line = myReader.ReadLine()) != null))
            {
                float yPosition = topMargin + (count * printFont.GetHeight(e.Graphics));

                e.Graphics.DrawString(line, printFont, myBrush, leftMargin, yPosition, new StringFormat());
                count++;
            }

            if (line != null)
                e.HasMorePages = true;
            else
                e.HasMorePages = false;

            myBrush.Dispose();
        }
        private void BtnPrintGolovi_Click(object sender, EventArgs e)
        {
            printDialog.Document = printDocument;
            string strText = "";
            foreach (object x in lbgolovi.Items)
            {
                strText = strText + x.ToString() + "\n";
            }

            myReader = new StringReader(strText);
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                this.printDocument.Print();
            }
        }

        private void Najvise_Kartona(PrintPageEventArgs e)
        {
            int count = 0;
            float leftMargin = e.MarginBounds.Left;
            float topMargin = e.MarginBounds.Top;
            string line = null;
            Font printFont = this.listaKartoni.Font;
            SolidBrush myBrush = new SolidBrush(Color.Black);

            float linesPerPage = e.MarginBounds.Height / printFont.GetHeight(e.Graphics);

            while (count < linesPerPage && ((line = myReader.ReadLine()) != null))
            {
                float yPosition = topMargin + (count * printFont.GetHeight(e.Graphics));

                e.Graphics.DrawString(line, printFont, myBrush, leftMargin, yPosition, new StringFormat());
                count++;
            }

            if (line != null)
                e.HasMorePages = true;
            else
                e.HasMorePages = false;

            myBrush.Dispose();
        }

        private void BtnPrintKartoni_Click(object sender, EventArgs e)
        {
            printDialog.Document = printDocument;
            string strText = "";
            foreach (object x in listaKartoni.Items)
            {
                strText = strText + x.ToString() + "\n";
            }

            myReader = new StringReader(strText);
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                this.printDocument.Print();
            }
        }
        private void Posjecenost(PrintPageEventArgs e)
        {
            int count = 0;
            float leftMargin = e.MarginBounds.Left;
            float topMargin = e.MarginBounds.Top;
            string line = null;
            Font printFont = this.lbPosjecenost.Font;
            SolidBrush myBrush = new SolidBrush(Color.Black);

            float linesPerPage = e.MarginBounds.Height / printFont.GetHeight(e.Graphics);

            while (count < linesPerPage && ((line = myReader.ReadLine()) != null))
            {
                float yPosition = topMargin + (count * printFont.GetHeight(e.Graphics));

                e.Graphics.DrawString(line, printFont, myBrush, leftMargin, yPosition, new StringFormat());
                count++;
            }

            if (line != null)
                e.HasMorePages = true;
            else
                e.HasMorePages = false;

            myBrush.Dispose();
        }
        private void BtnPrintPosjecenost_Click(object sender, EventArgs e)
        {
            printDialog.Document = printDocument;
            string strText = "";
            foreach (object x in lbPosjecenost.Items)
            {
                strText = strText + x.ToString() + "\n";
            }

            myReader = new StringReader(strText);
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                this.printDocument.Print();
            }
        }

        private void PrintDocument_EndPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            if (e.PrintAction == System.Drawing.Printing.PrintAction.PrintToPrinter)
            {
                MessageBox.Show("Gotovo je printanje", "Uspjesno!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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

        private void PromjenaJezikaINacijeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new Postavke().Show();
            this.Hide();
        }

        private void PromjenaNatjecanjaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void IzlazakIzAplikacijeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void PromjenaJezikaINacijeToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            new Postavke().Show();
            this.Hide();
        }

        private void PromjenaNatjecanjaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void IzlazakIzAplikacijeToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
