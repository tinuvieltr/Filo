using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FiloKiralama.Dialog.Musteri;
using FiloKiralama.Properties;

namespace FiloKiralama.Control.Musteri
{
    public partial class MusteriListControl : UserControl
    {
        public MusteriListControl()
        {
            InitializeComponent();

            var showButtonColumn = new DataGridViewImageColumn { Name = "show_column", HeaderText = "Değiştir", Width = 100 };
            showButtonColumn.Image = Resources.search24;
            const int columnIndex = 0;
            if (this.musteriListControl1.Columns["show_column"] == null)
            {
                this.musteriListControl1.Columns.Insert(columnIndex, showButtonColumn);
            }

            musteriListControl1.CellClick += musteriListControl1_CellClick;

            var autocomplete = new AutoCompleteStringCollection();
            autocomplete.AddRange((from a in Data.Musteriler
                                   select a.Ad).ToArray());
            textBox1.AutoCompleteCustomSource = autocomplete;

            autocomplete = new AutoCompleteStringCollection();
            autocomplete.AddRange((from a in Data.Musteriler
                                   select a.Yetkili).ToArray());
            textBox2.AutoCompleteCustomSource = autocomplete;
        }

        void musteriListControl1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != musteriListControl1.Columns["show_column"].Index) return;
            var rowIndex = e.RowIndex;
            var musteri = musteriListControl1.Rows[rowIndex].DataBoundItem as Entity.Musteri;
            var dialog = new MusteriEditDialog();
            dialog.Musteri = musteri;
            dialog.Show(this);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var musteri = textBox1.Text;
            var yetkilikisi = textBox2.Text;

            var result = (from a in Data.Musteriler
                          select a);
            if (string.IsNullOrEmpty(musteri) == false)
            {
                result = result.Where(x => x.Ad.Contains(musteri));
            }
            if (string.IsNullOrEmpty(yetkilikisi) == false)
            {
                result = result.Where(x => x.Yetkili.Contains(yetkilikisi));
            }

            musteriListControl1.DataSource = result.ToList();
            musteriListControl1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var dialog = new MusteriEditDialog();
            dialog.Show(this);
        }
    }
}
