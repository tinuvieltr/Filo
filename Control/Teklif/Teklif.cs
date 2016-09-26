using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FiloKiralama.Control.Teklif
{
    public partial class Teklif : UserControl
    {
        public Teklif()
        {
            InitializeComponent();
            dateTimePicker2.Value = DateTime.Now.AddMonths(1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var firma = FirmaAdiTextbox.Text;
            var date1 = dateTimePicker1.Value.Date;
            var date2 = dateTimePicker2.Value.Date;

            var result = (from a in Data.Teklifler
                          select a);
            if (string.IsNullOrEmpty(firma) != false)
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
