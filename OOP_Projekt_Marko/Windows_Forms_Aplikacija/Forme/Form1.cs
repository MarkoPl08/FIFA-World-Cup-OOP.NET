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
using Windows_Forms_Aplikacija.Forme;
using Windows_Forms_Aplikacija.Jezici;

namespace Windows_Forms_Aplikacija
{
    public partial class Form1 : Form
    {
        private const string HR = "hr",
                            EN = "en";
        public Form1()
        {
            Init();
            InitializeComponent();
        }
        private void Init()
        {
            if (System.IO.File.ReadAllText(Path.Combine(Environment.CurrentDirectory, @"..\..\..\..\Odabrana_Kultura.txt")) == EN)
            {
                PostaviKulturu(EN);
            }
            else
            {
                PostaviKulturu(HR);
            }
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

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        private void BtnPrijevod_Click(object sender, EventArgs e)
        {
            if (Thread.CurrentThread.CurrentCulture.Name == HR)
            {
                PostaviKulturu(EN);
                btnPrijevod.Text = "EN";
            }
            else
            {
                PostaviKulturu(HR);
                btnPrijevod.Text = "HR";
            }
            ZapisiKulturu();
        }
        private void ZapisiKulturu()
        {
            System.IO.File.WriteAllText(Path.Combine(Environment.CurrentDirectory, @"..\..\..\..\Odabrana_Kultura.txt"), btnPrijevod.Text.ToLower());
        }
        private void PbMuskoPrvenstvo_Click(object sender, EventArgs e)
        {
            if (new FileInfo(Path.Combine(Environment.CurrentDirectory, @"..\..\..\..\Omiljena_Reprezentacija.txt")).Length == 0 && new FileInfo(Path.Combine(Environment.CurrentDirectory, @"..\..\..\..\Omiljeni_Igraci.txt")).Length == 0)
            {
                new OdabirReprezentacije().Show();
            }
            else if (new FileInfo(Path.Combine(Environment.CurrentDirectory, @"..\..\..\..\Omiljena_Reprezentacija.txt")).Length != 0 && new FileInfo(Path.Combine(Environment.CurrentDirectory, @"..\..\..\..\Omiljeni_Igraci.txt")).Length == 0)
            {
                new OmiljeniIgraci().Show();
            }
            else
            {
                new Igraci().Show();
            }
            this.Hide();
            ZapisiSource("men");
        }
        private void PbZenskoPrvenstvo_Click(object sender, EventArgs e)
        {
            if (new FileInfo(Path.Combine(Environment.CurrentDirectory, @"..\..\..\..\Omiljena_Reprezentacija.txt")).Length == 0 && new FileInfo(Path.Combine(Environment.CurrentDirectory, @"..\..\..\..\Omiljeni_Igraci.txt")).Length == 0)
            {
                new OdabirReprezentacije().Show();
            }
            else if (new FileInfo(Path.Combine(Environment.CurrentDirectory, @"..\..\..\..\Omiljena_Reprezentacija.txt")).Length != 0 && new FileInfo(Path.Combine(Environment.CurrentDirectory, @"..\..\..\..\Omiljeni_Igraci.txt")).Length == 0)
            {
                new OmiljeniIgraci().Show();
            }
            else
            {
                new Igraci().Show();
            }
            this.Hide();
            ZapisiSource("women");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbOdabir.Text = Moji_Resursi.lbOdabir;
        }

        private void ZapisiSource(string source)
        {
            System.IO.File.WriteAllText(Path.Combine(Environment.CurrentDirectory, @"..\..\..\..\Source.txt"), source);
        }
    }
}
