using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FiloKiralama.Entity;

namespace FiloKiralama.Control
{
    public partial class AracEditControl : UserControl
    {
        private Arac _arac;

        public Arac Arac
        {
            get { return null; }
            set
            {
                _arac = value;
                BindData();
            }
            
        }

        public AracEditControl()
        {
            InitializeComponent();
        }

        private void BindData()
        {
            propertyGrid.SelectedObject = _arac;
        }
    }
}
