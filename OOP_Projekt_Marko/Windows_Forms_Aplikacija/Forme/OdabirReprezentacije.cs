using Podatkovni_Sloj;
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
using Windows_Forms_Aplikacija.Forme;
using Windows_Forms_Aplikacija.Jezici;

namespace Windows_Forms_Aplikacija
{
    public partial class OdabirReprezentacije : Form
    {
        public OdabirReprezentacije()
        {
            InitializeComponent();
                       
        }

        private void OdabirReprezentacije_Load(object sender, EventArgs e)
        {
            lbOmiljenaRepka.Text = Moji_Resursi.lbOmiljenaRepka;
            LoadData();
        }

        private async void LoadData()
        {
            GetData getData = new Podatkovni_Sloj.GetData();

            var Reprezentacije = await getData.GetReprezentacije();

            foreach (var Reprezentacija in Reprezentacije)
            {
                dbOdabirRepki.Items.Add($"{Reprezentacija.Country} ({Reprezentacija.FifaCode})");
            }
        }

        private void DbOdabirRepki_SelectedIndexChanged(object sender, EventArgs e)
        {
            string path = Path.Combine(Environment.CurrentDirectory, @"..\..\..\..\Omiljena_Reprezentacija.txt");
            string selectedValue = dbOdabirRepki.SelectedItem.ToString();
            File.WriteAllText(path, selectedValue);
            new OmiljeniIgraci().Show();
            this.Hide();
        }
    }
}
