using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using FastReport;
using FastReport.Editor;
using FiloKiralama.Dialog.Arac;
using FiloKiralama.Dialog.Musteri;
using FiloKiralama.Dialog.Teklif;
using FiloKiralama.Entity;
using Resources = FiloKiralama.Properties.Resources;

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

            this.dataGridView1.DataSource = Data.Dovizler;
            this.dataGridView2.DataSource = Data.Hatirlatmalar;

            var style = new DataGridViewCellStyle();
            style.Font = new Font(dataGridView2.Font, FontStyle.Bold);
            dataGridView2.Columns[1].DefaultCellStyle = style;
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
            var dialog = new MusteriSearchDialog();
            dialog.ShowDialog(this);
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

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var grid = (DataGridView)sender;
            if (grid.Columns[e.ColumnIndex].Name == "Column1")
            {
                if (((int)dataGridView1.Rows[e.RowIndex].Cells["Column2"].Value) == (int)Tanimlar.DovizKur.Dolar)
                {
                    e.Value = Resources.dollar;
                }
                else
                {
                    e.Value = Resources.euro;
                }
            }

            if (grid.Columns[e.ColumnIndex].Name == "Column3")
            {
                if (((int)dataGridView1.Rows[e.RowIndex].Cells["Column2"].Value) == (int)Tanimlar.DovizKur.Dolar)
                {
                    e.Value = Resources.up;
                }
                else
                {
                    e.Value = Resources.up;
                }
            }
        }

        private void dataGridView2_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var grid = (DataGridView)sender;
            if (grid.Columns[e.ColumnIndex].Name == "Column8")
            {
                if (((int)dataGridView2.Rows[e.RowIndex].Cells["Column7"].Value) <= 7)
                {
                    e.Value = Resources.alert_red;
                }
                else if (((int)dataGridView2.Rows[e.RowIndex].Cells["Column7"].Value) > 7 &&
                         ((int)dataGridView2.Rows[e.RowIndex].Cells["Column7"].Value) < 21)
                {
                    e.Value = Resources.alert_yellow;
                }
                else
                {
                    e.Value = Resources.alert_ok;
                }
            }
        }


    }
}
