using Newtonsoft.Json;
using Podatkovni_Sloj;
using QuickType;
using RestSharp;
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
    /// Interaction logic for DetaljiRepka.xaml
    /// </summary>
    public partial class DetaljiRepka : Window
    {

        public DetaljiRepka(Team tim)
        {
            InitializeComponent();
            LoadData(tim);            
        }

        private async void LoadData(Team team)
        {
            var nations = await GetData();
            Reprezentacije nacija = new Reprezentacije();
            foreach (var drzava in nations)
            {
                if (drzava.Country == team.Country)
                {
                    nacija = drzava;
                }
            }
            Init(nacija);
        }
        private Task<List<Reprezentacije>> GetData()
        {
            return Task.Run(() =>
            {
                var restClient = new RestClient("https://world-cup-json-2018.herokuapp.com/teams/results");


                var result = restClient.Execute<Reprezentacije>(new RestRequest());

                return JsonConvert.DeserializeObject<List<Reprezentacije>>(result.Content);

            });
        }
        private void Init(Reprezentacije nacija)
        {
            DetaljiRepke(nacija);
            Prijevod();
        }

        private void DetaljiRepke(Reprezentacije nacija)
        {
            nazivDrzave.Content = nacija.Country;
            kodDrzave.Content = nacija.FifaCode;
            odigraniDrzave.Content = nacija.GamesPlayed;
            pobijedeDrzave.Content = nacija.Wins;
            gubiciDrzave.Content = nacija.Losses;
            zabijeniDrzave.Content = nacija.GoalsFor;
            primljeniDrzave.Content = nacija.GoalsAgainst;
            razlikaDrzave.Content = nacija.GoalDifferential;
        }

        private void Prijevod()
        {
            lbName.Content = Moji_Resursi.lbName;
            lbKod.Content = Moji_Resursi.lbKod;
            lbOdigrani.Content = Moji_Resursi.lbOdigrani;
            lbPobijede.Content = Moji_Resursi.lbPobijede;
            lbGubici.Content = Moji_Resursi.lbGubici;
            lbNeodluceni.Content = Moji_Resursi.lbNeodluceni;
            lbZabijeni.Content = Moji_Resursi.lbZabijeni;
            lbPrimljeni.Content = Moji_Resursi.lbPrimljeni;
            lbRazlika.Content = Moji_Resursi.lbRazlika;
            lbDetaljiORepki.Content = Moji_Resursi.lbDetaljiORepki;
        }
    }
}
