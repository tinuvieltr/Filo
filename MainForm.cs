using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using FastReport;
using FiloKiralama.Dialog.Arac;
using FiloKiralama.Dialog.Teklif;

namespace FiloKiralama
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Data.InitData();


        }

        private void mainRibbon_Click(object sender, EventArgs e)
        {

        }

        #region Genel Ribbon Buttons

        private void aracRibbonButton_Click(object sender, EventArgs e)
        {
            var dialog = new AracSearchDialog();
            dialog.ShowDialog(this);
        }

        private void teklifRibbonButton_Click(object sender, EventArgs e)
        {
            var dialog = new TeklifLSearchDialog();
            dialog.ShowDialog(this);
        }

        private void lastikRibbonButton_Click(object sender, EventArgs e)
        {

        }

        private void hukukRibbonButton_Click(object sender, EventArgs e)
        {

        }

        private void finansRibbonButton_Click(object sender, EventArgs e)
        {

        }


        #endregion

        #region Tanım Ribbon Buttons

        private void musteriTanimButton_Click(object sender, EventArgs e)
        {

        }

        private void kullaniciTanimButton_Click(object sender, EventArgs e)
        {

        }

        private void modelTanimButton_Click(object sender, EventArgs e)
        {

        }

        private void sigortaFirmaTanimButton_Click(object sender, EventArgs e)
        {

        }

        private void bankaTanimButton_Click(object sender, EventArgs e)
        {

        }

        private void yedekAracTanimButton_Click(object sender, EventArgs e)
        {

        }

        private void avukatTanimButton_Click(object sender, EventArgs e)
        {

        }

        #endregion

    }
}
