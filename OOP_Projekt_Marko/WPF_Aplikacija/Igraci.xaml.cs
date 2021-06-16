using Podatkovni_Sloj;
using QuickType;
using System;
using System.Collections.Generic;
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
using WPF_Aplikacija.Jezici;

namespace WPF_Aplikacija
{
    /// <summary>
    /// Interaction logic for Igraci.xaml
    /// </summary>
    public partial class Igraci : Window
    {
        public Igraci(string s, Team home, string away)
        {
            InitializeComponent();
            Task task = LoadData(s, home, away);
            init();

        }

        private void init()
        {
            Prijevod();
        }

        private void Prijevod()
        {
            lbIme.Content = Moji_Resursi.lbIme;
            lbNumber.Content = Moji_Resursi.lbNumber;
            lbPosition.Content = Moji_Resursi.lbPosition;
            lbCaptain.Content = Moji_Resursi.lbCaptain;
            lbGoals.Content = Moji_Resursi.lbGoals;
            lbYellows.Content = Moji_Resursi.lbYellows;
        }

        private async Task LoadData(string s, Team home, string away)
        {
            GetData getData = new Podatkovni_Sloj.GetData();

            var igraci = await getData.GetUtakmice();

            StartingEleven odabrani = new StartingEleven();

            Utakmice utakmica = new Utakmice();

            foreach (var igrac in igraci)
            {
                if (igrac.HomeTeam.Country == home.Country || igrac.AwayTeam.Country == home.Country)
                {
                    if (igrac.HomeTeam.Country == away.ToString() || igrac.AwayTeam.Country == away.ToString())
                    {
                        utakmica = igrac;
                    }
                }

                foreach (var player in utakmica.HomeTeamStatistics.StartingEleven)
                {
                    if (player.Name == s)
                    {
                        odabrani = player;
                    }
                }
                foreach (var player in utakmica.AwayTeamStatistics.StartingEleven)
                {
                    if (player.Name == s)
                    {
                        odabrani = player;
                    }
                }

                int brojGolova = 0;
                int brojZutih = 0;

                foreach (var dogadaj in utakmica.HomeTeamEvents)
                {
                    if (dogadaj.TypeOfEvent == TypeOfEvent.Goal || dogadaj.TypeOfEvent == TypeOfEvent.GoalPenalty)
                    {
                        if (dogadaj.Player == odabrani.Name)
                        {
                            brojGolova++;
                        }
                    }
                    if (dogadaj.TypeOfEvent == TypeOfEvent.YellowCard || dogadaj.TypeOfEvent == TypeOfEvent.YellowCardSecond)
                    {
                        if (dogadaj.Player == odabrani.Name)
                        {
                            brojZutih++;
                        }
                    }
                }
                foreach (var dogadaj in utakmica.AwayTeamEvents)
                {
                    if (dogadaj.TypeOfEvent == TypeOfEvent.Goal || dogadaj.TypeOfEvent == TypeOfEvent.GoalPenalty)
                    {
                        if (dogadaj.Player == odabrani.Name)
                        {
                            brojGolova++;
                        }
                    }
                    if (dogadaj.TypeOfEvent == TypeOfEvent.YellowCard || dogadaj.TypeOfEvent == TypeOfEvent.YellowCardSecond)
                    {
                        if (dogadaj.Player == odabrani.Name)
                        {
                            brojZutih++;
                        }
                    }
                }

                igracIme.Content = odabrani.Name;
                igracBroj.Content = odabrani.ShirtNumber;
                igracPozicija.Content = odabrani.Position;
                igracCaptain.Content = odabrani.Captain;
                igracGol.Content = brojGolova;
                igracZuti.Content = brojZutih;
            }


        }

    }
}
