using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FiloKiralama.Entity;

namespace FiloKiralama
{
    public class Data
    {
        public static List<AracModel> AracModeller = new List<AracModel>();

        public static List<Arac> Araclar = new List<Arac>();

        public static List<Musteri> Musteriler = new List<Musteri>();
		
        public static void InitData()
        {
            #region Araç Model

            var model = new AracModel();
            model.Id = 1;
            model.Ad = "2008 Active 1.6 e-HDI ETG6 92 HP Stop&Start";
            AracModeller.Add(model);

            model = new AracModel();
            model.Id = 1;
            model.Ad = "208 GTİ BY PS";
            AracModeller.Add(model);

            #endregion

            #region Arac

            #region 06DA1112
            var arac = new Arac();
            arac.Id = 1;
            arac.Model = AracModeller[0];
            arac.MotorNo = "MTR112";
            arac.SaseNo = "SASE112";
            arac.Plaka = "06DA1112";
            arac.MusteriId = 1;
            arac.Renk = Color.Black.Name;
            arac.TescilTarihi = new DateTime(2015, 2, 16);
            Araclar.Add(arac);
            #endregion

            #region 06DA3412
            arac = new Arac();
            arac.Id = 2;
            arac.Model = AracModeller[0];
            arac.MotorNo = "MTR312";
            arac.SaseNo = "SASE312";
            arac.Plaka = "06DA3412";
            arac.MusteriId = 2;
            arac.Renk = Color.White.Name;
            arac.TescilTarihi = new DateTime(2015, 7, 11);
            Araclar.Add(arac);
            #endregion

            #endregion

            #region Müşteri

            var musteri = new Musteri();
            musteri.Id = 1;
            musteri.Ad = "Garanti Bankası";
            musteri.VergiNo = "1";
            musteri.VergiDaire = "Ankara";
            musteri.Tel = "1";
            musteri.Email = "info@garanti.com";
            musteri.Yetkili = "Mustafa Özdemir";
            Musteriler.Add(musteri);

            musteri = new Musteri();
            musteri.Id = 2;
            musteri.Ad = "MY Kuyumculuk";
            musteri.VergiNo = "1";
            musteri.VergiDaire = "Ankara";
            musteri.Tel = "1";
            musteri.Email = "info@mykuyumculuk.com";
            musteri.Yetkili = "Zeki Altan";
            Musteriler.Add(musteri);


            #endregion
        }
    }
}
