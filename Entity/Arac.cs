using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FiloKiralama.Entity
{
    public class Arac
    {
        public int Id { get; set; }
        public string Plaka { get; set; }
        public int MusteriId { get; set; }
        public int ModelId { get; set; }
        public DateTime TescilTarihi { get; set; }
        public string SaseNo { get; set; }
        public string MotorNo { get; set; }
        public string Renk { get; set; }
        public int SozlesmeId { get; set; }
    }
}

