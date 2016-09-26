using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace FiloKiralama.Dialog.Splash
{
    public partial class Splash : Form
    {
        private int _sayac = 0;
        public Splash()
        {
            InitializeComponent();
            this.CenterToScreen();

            var timer = new Timer();
            timer.Tick += timer_Tick;
            timer.Start();
            timer.Interval = 250;
        }

        void timer_Tick(object sender, EventArgs e)
        {
            _sayac++;
            Opacity = 1 - ((double)_sayac) / 8;
            if (_sayac == 8)
            {
                this.Visible = false;
                var mainForm = new MainForm();
                mainForm.Show();
            }

        }

    }
}
