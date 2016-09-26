using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FiloKiralama.Entity;

namespace FiloKiralama.Control.Musteri
{
    public partial class MusteriEditControl : UserControl
    {
        private FiloKiralama.Entity.Musteri _musteri;

        public FiloKiralama.Entity.Musteri Musteri
        {
            get { return null; }
            set
            {
                _musteri = value;
                BindData();
            }

        }

        public MusteriEditControl()
        {
            InitializeComponent();
        }

        private void BindData()
        {
            propertyGrid1.SelectedObject = _musteri;
        }
    }
}
