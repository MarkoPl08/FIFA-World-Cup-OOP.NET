using Podatkovni_Sloj;
using QuickType;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPF_Aplikacija
{
    /// <summary>
    /// Interaction logic for Igraliste.xaml
    /// </summary>
    public partial class Igraliste : Window
    {
        int rezHeight;
        int rezWidth;
        Team home;
        string away;
        public Igraliste(Team domaci, string gosti)
        {
            InitializeComponent();
            this.Loaded += Igraliste_Loaded;
            LoadData(domaci, gosti);
            home = domaci;
            away = gosti;
        }

        private void Igraliste_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {   // Open the text file using a stream reader.
                using (StreamReader sr = new StreamReader(@"../../../../Odabrana_Rezolucija.txt"))
                {
                    // Read the stream to a string, and write the string to the console.
                    String line = sr.ReadToEnd();
                    string[] parts = line.Split(':');
                    rezWidth = int.Parse(parts[0]);
                    rezHeight = int.Parse(parts[1]);
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("Nije moguce pronaci tekstualnu datoteku!!");
                Console.WriteLine(ex.Message);
            }
            this.Width = rezWidth;
            this.Height = rezHeight;
            if (rezHeight == 0 || rezWidth == 0)
            {
                this.Width = 800;
                this.Height = 600;
            }
        }
        private async void LoadData(Team domaci, string gosti)
        {
            GetData getData = new Podatkovni_Sloj.GetData();

            var igraci = await getData.GetUtakmice();

            Utakmice utakmica = new Utakmice();

            foreach (var igrac in igraci)
            {
                if (igrac.HomeTeam.Country == domaci.Country || igrac.AwayTeam.Country == domaci.Country)
                {
                    if (igrac.HomeTeam.Country == gosti.ToString() || igrac.AwayTeam.Country == gosti.ToString())
                    {
                        utakmica = igrac;
                    }
                }
            }

            for (int i = 0; i < 11; i++)
            {
                if (utakmica.HomeTeamStatistics.StartingEleven[i].Position == Position.Goalie)
                {
                    Label lbGK = new Label();
                    lbGK.Content = utakmica.HomeTeamStatistics.StartingEleven[i].ShirtNumber;
                    lbGK.Foreground = System.Windows.Media.Brushes.LightGray;
                    lbGK.FontSize = 30;
                    lbGK.Margin = new Thickness(0,0,0,0);
                    lbGK.HorizontalContentAlignment = HorizontalAlignment.Center;
                    stackGKDomaci.Children.Add(lbGK);
                 
                    Button btnGK = new Button();
                    btnGK.Content = utakmica.HomeTeamStatistics.StartingEleven[i].Name;
                    btnGK.Height = 25;
                    btnGK.Width = 120; 
                    btnGK.Background = System.Windows.Media.Brushes.Green;
                    btnGK.Foreground = System.Windows.Media.Brushes.DarkRed;
                    btnGK.Click += Igrac_Click;
                    stackGKDomaci.Children.Add(btnGK);
                }
                else if (utakmica.HomeTeamStatistics.StartingEleven[i].Position == Position.Defender)
                {
                    Label lbDef = new Label();
                    lbDef.Content = utakmica.HomeTeamStatistics.StartingEleven[i].ShirtNumber;
                    lbDef.Foreground = System.Windows.Media.Brushes.LightGray;
                    lbDef.FontSize = 30;
                    lbDef.Margin = new Thickness(0, 0, 0, 0);
                    lbDef.HorizontalContentAlignment = HorizontalAlignment.Center;
                    stackDefDomaci.Children.Add(lbDef);
                    
                    Button btnDef = new Button();
                    btnDef.Content = utakmica.HomeTeamStatistics.StartingEleven[i].Name;
                    btnDef.Height = 25;
                    btnDef.Width = 120;
                    btnDef.Background = System.Windows.Media.Brushes.Green;
                    btnDef.Foreground = System.Windows.Media.Brushes.DarkRed;
                    btnDef.Click += Igrac_Click;
                    stackDefDomaci.Children.Add(btnDef);
                    
                }
                else if (utakmica.HomeTeamStatistics.StartingEleven[i].Position == Position.Midfield)
                {
                    Label lbMid = new Label();
                    lbMid.Content = utakmica.HomeTeamStatistics.StartingEleven[i].ShirtNumber;
                    lbMid.Foreground = System.Windows.Media.Brushes.LightGray;
                    lbMid.FontSize = 30;
                    lbMid.Margin = new Thickness(0, 0, 0, 0);
                    lbMid.HorizontalContentAlignment = HorizontalAlignment.Center;
                    stackMidDomaci.Children.Add(lbMid);

                    Button btnMid = new Button();
                    btnMid.Content = utakmica.HomeTeamStatistics.StartingEleven[i].Name;
                    btnMid.Height = 25;
                    btnMid.Width = 120;
                    btnMid.Background = System.Windows.Media.Brushes.Green;
                    btnMid.Foreground = System.Windows.Media.Brushes.DarkRed;
                    btnMid.Click += Igrac_Click;
                    stackMidDomaci.Children.Add(btnMid);
                }
                else if (utakmica.HomeTeamStatistics.StartingEleven[i].Position == Position.Forward)
                {
                    Label lbFor = new Label();
                    lbFor.Content = utakmica.HomeTeamStatistics.StartingEleven[i].ShirtNumber;
                    lbFor.Foreground = System.Windows.Media.Brushes.LightGray;
                    lbFor.FontSize = 30;
                    lbFor.Margin = new Thickness(0, 0, 0, 0);
                    lbFor.HorizontalContentAlignment = HorizontalAlignment.Center;
                    stackFowDomaci.Children.Add(lbFor);

                    Button btnFor = new Button();
                    btnFor.Content = utakmica.HomeTeamStatistics.StartingEleven[i].Name;
                    btnFor.Height = 25;
                    btnFor.Width = 120;
                    btnFor.Background = System.Windows.Media.Brushes.Green;
                    btnFor.Foreground = System.Windows.Media.Brushes.DarkRed;
                    btnFor.Click += Igrac_Click;
                    stackFowDomaci.Children.Add(btnFor);
                }
            }
            for (int i = 0; i < 11; i++)
            {
                if (utakmica.AwayTeamStatistics.StartingEleven[i].Position == Position.Goalie)
                {
                    Label lbGK = new Label();
                    lbGK.Content = utakmica.AwayTeamStatistics.StartingEleven[i].ShirtNumber;
                    lbGK.Foreground = System.Windows.Media.Brushes.LightGray;
                    lbGK.FontSize = 30;
                    lbGK.Margin = new Thickness(0, 0, 0, 0);
                    lbGK.HorizontalContentAlignment = HorizontalAlignment.Center;
                    stackGKGosti.Children.Add(lbGK);

                    Button btnGK = new Button();
                    btnGK.Content = utakmica.AwayTeamStatistics.StartingEleven[i].Name;
                    btnGK.Height = 25;
                    btnGK.Width = 120;
                    btnGK.Background = System.Windows.Media.Brushes.Green;
                    btnGK.Foreground = System.Windows.Media.Brushes.DarkRed;
                    btnGK.Click += Igrac_Click;
                    stackGKGosti.Children.Add(btnGK);
                }
                else if (utakmica.AwayTeamStatistics.StartingEleven[i].Position == Position.Defender)
                {
                    Label lbDef = new Label();
                    lbDef.Content = utakmica.AwayTeamStatistics.StartingEleven[i].ShirtNumber;
                    lbDef.Foreground = System.Windows.Media.Brushes.LightGray;
                    lbDef.FontSize = 30;
                    lbDef.Margin = new Thickness(0, 0, 0, 0);
                    lbDef.HorizontalContentAlignment = HorizontalAlignment.Center;
                    stackDefGosti.Children.Add(lbDef);

                    Button btnDef = new Button();
                    btnDef.Content = utakmica.AwayTeamStatistics.StartingEleven[i].Name;
                    btnDef.Height = 25;
                    btnDef.Width = 120;
                    btnDef.Background = System.Windows.Media.Brushes.Green;
                    btnDef.Foreground = System.Windows.Media.Brushes.DarkRed;
                    btnDef.Click += Igrac_Click;
                    stackDefGosti.Children.Add(btnDef);

                }
                else if (utakmica.AwayTeamStatistics.StartingEleven[i].Position == Position.Midfield)
                {
                    Label lbMid = new Label();
                    lbMid.Content = utakmica.AwayTeamStatistics.StartingEleven[i].ShirtNumber;
                    lbMid.Foreground = System.Windows.Media.Brushes.LightGray;
                    lbMid.FontSize = 30;
                    lbMid.Margin = new Thickness(0, 0, 0, 0);
                    lbMid.HorizontalContentAlignment = HorizontalAlignment.Center;
                    stackMidGosti.Children.Add(lbMid);

                    Button btnMid = new Button();
                    btnMid.Content = utakmica.AwayTeamStatistics.StartingEleven[i].Name;
                    btnMid.Height = 25;
                    btnMid.Width = 120;
                    btnMid.Background = System.Windows.Media.Brushes.Green;
                    btnMid.Foreground = System.Windows.Media.Brushes.DarkRed;
                    btnMid.Click += Igrac_Click;
                    stackMidGosti.Children.Add(btnMid);
                }
                else if (utakmica.AwayTeamStatistics.StartingEleven[i].Position == Position.Forward)
                {
                    Label lbFor = new Label();
                    lbFor.Content = utakmica.AwayTeamStatistics.StartingEleven[i].ShirtNumber;
                    lbFor.Foreground = System.Windows.Media.Brushes.LightGray;
                    lbFor.FontSize = 30;
                    lbFor.Margin = new Thickness(0, 0, 0, 0);
                    lbFor.HorizontalContentAlignment = HorizontalAlignment.Center;
                    stackFowGosti.Children.Add(lbFor);

                    Button btnFor = new Button();
                    btnFor.Content = utakmica.AwayTeamStatistics.StartingEleven[i].Name;
                    btnFor.Height = 25;
                    btnFor.Width = 120;
                    btnFor.Background = System.Windows.Media.Brushes.Green;
                    btnFor.Foreground = System.Windows.Media.Brushes.DarkRed;
                    btnFor.Click += Igrac_Click;
                    stackFowGosti.Children.Add(btnFor);
                }
            }

        }

        private void Igrac_Click(object sender, RoutedEventArgs e)
        {
            string s = (sender as Button).Content.ToString();
            Igraci prikaz = new Igraci(s, home, away);
            prikaz.Show();
        }

        private void Zatvori_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Jeste li sigurni da zelite izaci iz aplikacije?", "Warning", MessageBoxButton.YesNoCancel, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                Environment.Exit(0);
            }
            else
            {
                return;
            }
        }
    }
}
