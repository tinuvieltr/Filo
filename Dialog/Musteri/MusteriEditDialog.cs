using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FiloKiralama.Dialog.Musteri
{
    public partial class MusteriEditDialog : Form
    {
        public Entity.Musteri Musteri
        {
            get { return musteriEditControl1.Musteri; }
            set { musteriEditControl1.Musteri = value; }
        }


        public MusteriEditDialog()
        {
            InitializeComponent();
        }

        private void AracEditDialog_Load(object sender, EventArgs e)
        {
            if (musteriEditControl1.Musteri != null)
                Text = musteriEditControl1.Musteri.Ad;
        }
    }
}
