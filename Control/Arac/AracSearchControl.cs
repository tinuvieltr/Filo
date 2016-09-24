using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FiloKiralama.Control
{
    public partial class AracSearchControl : UserControl
    {
        public AracSearchControl()
        {
            InitializeComponent();
        }

        private void AracSearchControl_Load(object sender, EventArgs e)
        {
            musteriCombo.DataSource = Data.Musteriler;
            musteriCombo.DisplayMember = "Ad";
            musteriCombo.ValueMember = "Id";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var mustId = Convert.ToInt32(musteriCombo.SelectedValue);
            var sase = saseTextbox.Text;
            var plaka = plakaTextbox.Text;

            var result = (from a in Data.Araclar
                          select a);
            if (mustId > 0)
            {
                result = result.Where(x => x.MusteriId == mustId);
            }
            if (string.IsNullOrEmpty(sase) == false)
            {
                result = result.Where(x => x.SaseNo == sase);
            }
            if (string.IsNullOrEmpty(plaka) == false)
            {
                result = result.Where(x => x.Plaka == plaka);
            }

            aracListControl1.aracGrid.DataSource = result.ToList();

        }
    }
}
