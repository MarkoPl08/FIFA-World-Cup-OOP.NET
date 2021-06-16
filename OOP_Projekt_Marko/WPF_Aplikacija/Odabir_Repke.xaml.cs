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
    /// Interaction logic for Odabir_Repke.xaml
    /// </summary>
    public partial class Odabir_Repke : Window
    {
        List<Utakmice> lista;
        public Odabir_Repke()
        {
            InitializeComponent();
            LoadData();
            init();
        }

        private void init()
        {
            Prijevod();
        }

        private void Prijevod()
        {
            Dalje.Content = Moji_Resursi.Dalje;
            Detalji.Content = Moji_Resursi.Detalji;
            lbDomaciTim.Content = Moji_Resursi.lbDomaciTim;
            lbGostujuciTim.Content = Moji_Resursi.lbGostujuciTim;
        }

        private async void LoadData()
        {
            GetData getData = new Podatkovni_Sloj.GetData();

            var Reprezentacije = await getData.GetUtakmice();
            lista = Reprezentacije;
            List<Team> timovi = new List<Team>();
            for (int i = 0; i < 16; i++)
            {
                timovi.Add(Reprezentacije[i].HomeTeam);
                timovi.Add(Reprezentacije[i].AwayTeam);
            }
            foreach (var tim in timovi)
            {
                cbDomaci.Items.Add(tim);
            }
        }
        private void cbDomaci_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            cbGosti.Items.Clear();
            var Reprezentacije = cbDomaci.SelectedValue as Team;
            for (int i = 0; i < lista.Count(); i++)
            {
                if (lista[i].HomeTeam.Country == Reprezentacije.Country)
                {
                    cbGosti.Items.Add(lista[i].AwayTeam.Country);
                }
                else if (lista[i].AwayTeam.Country == Reprezentacije.Country)
                {
                    cbGosti.Items.Add(lista[i].HomeTeam.Country);
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var domaci = cbDomaci.SelectedValue as Team;
            var prikazIgralista = new Igraliste(domaci, cbGosti.SelectedItem.ToString());
            this.Visibility = Visibility.Hidden;
            prikazIgralista.Show();
        }

        private void Detalji_Click(object sender, RoutedEventArgs e)
        {
            var Domaci = cbDomaci.SelectedValue as Team;
            if (Domaci == null)
            {
                MessageBox.Show("Odaberite Reprezentaciju!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            var DetaljiORepki = new DetaljiRepka(Domaci);
            DetaljiORepki.Show();
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
