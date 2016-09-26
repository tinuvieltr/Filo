using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FiloKiralama.Entity
{
    public class TeklifArac
    {
        public int Id { get; set; }
        public int TeklifId { get; set; }
        public int ModelId { get; set; }
        public int Vade { get; set; }
        public double Tutar { get; set; }
        public Tanimlar.DovizKur Birim { get; set; }
        public string OpsiyonOzellikleri { get; set; }

    }
}
