using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FiloKiralama.Entity
{
    public class Teklif
    {
        public int Id { get; set; }
        public string Firma { get; set; }
        public string Yetkili { get; set; }
        public string Telefon { get; set; }
        public string Faks { get; set; }
        public string Email { get; set; }
        public DateTime GecerlilikSuresi { get; set; }
        public int YillikKmSiniri { get; set; }
        public DateTime TeklifTarihi { get; set; }
        public string MusteriTemsilcisi { get; set; }
        public string TemsilciTelefon { get; set; }
        public string TemsilciEmail { get; set; }
        public string TeklifNo { get; set; }
        public List<TeklifArac> ListTeklifArac { get; set; }
    }
}
