using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FiloKiralama.Dialog.Arac
{
    public partial class AracEditDialog : Form
    {
        public Entity.Arac Arac
        {
            get { return aracEditControl.Arac; }
            set { aracEditControl.Arac = value; }
        }

        public AracEditDialog()
        {
            InitializeComponent();
        }

        private void AracEditDialog_Load(object sender, EventArgs e)
        {
            if (aracEditControl.Arac != null)
                Text = aracEditControl.Arac.Plaka;
        }


    }
}
