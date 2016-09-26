using System;
using System.Linq;
using System.Windows.Forms;
using FastReport;
using FiloKiralama.Properties;

namespace FiloKiralama.Control.Teklif
{
    public partial class Teklif : UserControl
    {
        public Teklif()
        {
            InitializeComponent();

            teklifListControl1.Visible = false;
            dateTimePicker2.Value = DateTime.Now.AddMonths(1);
            var showButtonColumn = new DataGridViewImageColumn { Name = "show_column", HeaderText = "Çıktı", Width = 100 };
            showButtonColumn.Image = Resources.search24;
            const int columnIndex = 0;
            if (this.teklifListControl1.Columns["show_column"] == null)
            {
                this.teklifListControl1.Columns.Insert(columnIndex, showButtonColumn);
            }

            teklifListControl1.CellClick += aracGrid_CellClick;
        }

        void aracGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != teklifListControl1.Columns["show_column"].Index) return;
            var rowIndex = e.RowIndex;
            var teklifRow = teklifListControl1.Rows[rowIndex].DataBoundItem as Entity.Teklif;
            if (teklifRow == null) return;
            var frx = new Report();
            frx.Load(@"../../Reports\teklifrapor.frx");
            frx.SetParameterValue("paramKime", teklifRow.Firma);
            frx.SetParameterValue("paramDikk", teklifRow.Yetkili);
            frx.SetParameterValue("paramKayitNo", teklifRow.TeklifNo);
            frx.SetParameterValue("paramTelefon", teklifRow.Telefon);
            frx.SetParameterValue("paramFaks", teklifRow.Faks);
            frx.SetParameterValue("paramTelefon", teklifRow.Telefon);
            frx.SetParameterValue("paramYetkiliGonderen", teklifRow.Telefon);
            frx.SetParameterValue("paramYetkiliEposta", teklifRow.Email);
            frx.SetParameterValue("paramYetkiliTarih", teklifRow.TeklifTarihi);
            frx.SetParameterValue("paramYetkiliTelefon", teklifRow.TemsilciTelefon);

            var teklifAracRow = (from x in teklifRow.ListTeklifArac
                                 where x.Id == teklifRow.Id
                                 select x).FirstOrDefault();

            frx.SetParameterValue("paramModel1", teklifAracRow.OpsiyonOzellikleri);
            frx.SetParameterValue("paramModel2", teklifAracRow.OpsiyonOzellikleri);
            frx.SetParameterValue("paramVade1", teklifAracRow.Vade);
            frx.SetParameterValue("paramVade2", teklifAracRow.Vade);
            frx.SetParameterValue("paramKira1", teklifAracRow.Tutar);
            frx.SetParameterValue("paramKira2", teklifAracRow.Tutar * 3);


            frx.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var firma = textBox1.Text;
            var date1 = dateTimePicker1.Value.Date;
            var date2 = dateTimePicker2.Value.Date;

            var result = (from a in Data.Teklifler
                          select a);
            if (string.IsNullOrEmpty(firma) == false)
            {
                result = result.Where(x => x.Firma.Contains(firma));
            }
            if (dateTimePicker1.Value.Date != null)
            {
                result = result.Where(x => x.TeklifTarihi >= date1);
            }
            if (dateTimePicker2.Value.Date != null)
            {
                result = result.Where(x => x.TeklifTarihi < date2);
            }

            teklifListControl1.DataSource = result.ToList();
            teklifListControl1.Visible = true;
        }
    }
}
