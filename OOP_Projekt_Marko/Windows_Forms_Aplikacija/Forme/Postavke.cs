using Podatkovni_Sloj;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows_Forms_Aplikacija.Jezici;

namespace Windows_Forms_Aplikacija.Forme
{
   
    public partial class Postavke : Form
    {
        private const string HR = "hr",
                         EN = "en";

        public Postavke()
        {
            InitializeComponent();
            LoadData();
        }

        private async void LoadData()
        {
            GetData getData = new Podatkovni_Sloj.GetData();

            var Reprezentacije = await getData.GetReprezentacije();

            foreach (var Reprezentacija in Reprezentacije)
            {
                dbRepkaOdabir.Items.Add($"{Reprezentacija.Country} ({Reprezentacija.FifaCode})");
            }
        }

        private void DbRepkaOdabir_SelectedIndexChanged(object sender, EventArgs e)
        {
            string path = Path.Combine(Environment.CurrentDirectory, @"..\..\..\..\Omiljena_Reprezentacija.txt");
            string selectedValue = dbRepkaOdabir.SelectedItem.ToString();
            File.WriteAllText(path, selectedValue);
        }
        private void BtnSpremi_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dialogResult==DialogResult.Yes)
            {
                new OmiljeniIgraci().Show();
                this.Hide();
            }
            else
            {
                return;
            }
        }
        private void BtnPrijevodOpcije_Click(object sender, EventArgs e)
        {
            if (Thread.CurrentThread.CurrentCulture.Name == HR)
            {
                PostaviKulturu(EN);
                btnPrijevodOpcije.Text = Moji_Resursi.btnPrijevodOpcije;
            }
            else
            {
                PostaviKulturu(HR);
                btnPrijevodOpcije.Text = Moji_Resursi.btnPrijevodOpcije;
            }
            ZapisiKulturu();
        }

        private void ZapisiKulturu()
        {
            System.IO.File.WriteAllText(Path.Combine(Environment.CurrentDirectory, @"..\..\..\..\Odabrana_Kultura.txt"), btnPrijevodOpcije.Text.ToLower());
        }
        private void PostaviKulturu(string kultura)
        {
            try
            {
                //postavi lokalizaciju = prevodi
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(kultura);
                //postavi globalizaciju = datum,vrijeme,valute
                Thread.CurrentThread.CurrentCulture = new CultureInfo(kultura);

                foreach (Control control in Controls)
                {
                    var resursi = new ComponentResourceManager(typeof(Form1));
                    resursi.ApplyResources(control, control.Name, new CultureInfo(kultura));
                }

                lbRepkaOpcije.Text = Moji_Resursi.lbRepkaOpcije;
                lbJezikOpcije.Text = Moji_Resursi.lbJezikOpcije;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
