using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;

namespace FiloKiralama.Entity
{
    public class Arac
    {
        [Category("Genel")]
        [ReadOnly(true)]
        [DisplayName("Araç Id")]
        [Description("Araç Kimlik Numarası")]
        public int Id { get; set; }

        [Category("Genel")]
        [DisplayName("Plaka")]
        [Description("Araç Plakası")]
        public string Plaka { get; set; }

        [Category("Genel")]
        [DisplayName("Modeli")]
        [Description("")]
        public AracModel Model { get; set; }

        [Category("Genel")]
        [DisplayName("Tescil Tarihi")]
        [Description("")]
        public DateTime TescilTarihi { get; set; }

        [Category("Genel")]
        [DisplayName("Şase Numarası")]
        [Description("")]
        public string SaseNo { get; set; }

        [Category("Genel")]
        [DisplayName("Motor Numarası")]
        [Description("")]
        public string MotorNo { get; set; }

        private string _renk;

        [Category("Genel")]
        [DisplayName("Renk")]
        [Description("")]
        public string Renk { get; set; }

        [Browsable(false)]
        public int MusteriId { get; set; }

        [Browsable(false)]
        public int SozlesmeId { get; set; }

    }
}

