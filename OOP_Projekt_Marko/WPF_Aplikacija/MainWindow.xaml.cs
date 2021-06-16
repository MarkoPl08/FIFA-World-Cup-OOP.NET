using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPF_Aplikacija.Jezici;

namespace WPF_Aplikacija
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const string HR = "hr",
                            EN = "en";
        public MainWindow()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            //btnJezik.Content = HR;
        }
        private void btnJezik_Click(object sender, RoutedEventArgs e)
        {
            if (Thread.CurrentThread.CurrentCulture.Name == HR)
            {
                PostaviKulturu(EN);
                btnJezik.Content = "EN";
            }
            else
            {
                PostaviKulturu(HR);
                btnJezik.Content = "HR";
            }
            ZapisiKulturu();
        }

        private void PostaviKulturu(string kultura)
        {
            try
            {
                //postavi lokalizaciju = prevodi
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(kultura);
                //postavi globalizaciju = datum,vrijeme,valute
                Thread.CurrentThread.CurrentCulture = new CultureInfo(kultura);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        private void ZapisiKulturu()
        {
            System.IO.File.WriteAllText(@"..\..\..\..\Odabrana_Kultura.txt", btnJezik.Content.ToString().ToLower());
        }

        private void imageMuski_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Odabir_Repke Odabir_Repke = new Odabir_Repke();
            this.Visibility = Visibility.Hidden;
            Odabir_Repke.Show();
            ZapisiSource("men");
        }

        private void imageZenski_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Odabir_Repke Odabir_Repke = new Odabir_Repke();
            this.Visibility = Visibility.Hidden;
            Odabir_Repke.Show();
            ZapisiSource("women");
        }
        private void ZapisiSource(string source)
        {
            System.IO.File.WriteAllText(@"..\..\..\..\Source.txt", source);
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            var radiobtn = sender as RadioButton;
            System.IO.File.WriteAllText(@"../../../../Odabrana_Rezolucija.txt", radiobtn.Content.ToString());
        }

    }
}
