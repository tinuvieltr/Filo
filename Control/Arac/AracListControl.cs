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
    public partial class AracListControl : UserControl
    {
        public AracListControl()
        {
            InitializeComponent();

            var uninstallButtonColumn = new DataGridViewButtonColumn { Name = "show_column", Text = "Göster" };
            const int columnIndex = 0;

            if (aracGrid.Columns["show_column"] == null)
            {
                aracGrid.Columns.Insert(columnIndex, uninstallButtonColumn);
            }

            aracGrid.CellClick += aracGrid_CellClick;
        }

        void aracGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == aracGrid.Columns["show_column"].Index)
            {
                //Do Something with your button.
            }
        }

        
    }
}
