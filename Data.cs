using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

        public static List<Teklif> Teklifler = new List<Teklif>();

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

            #region 06ED2636
            arac = new Arac();
            arac.Id = 1;
            arac.Model = AracModeller[0];
            arac.MotorNo = "MTR5895";
            arac.SaseNo = "SASE333";
            arac.Plaka = "06ED2636";
            arac.MusteriId = 1;
            arac.Renk = Color.Blue.Name;
            arac.TescilTarihi = new DateTime(2016, 2, 16);
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

            #region Teklif

            var teklif = new Teklif();
            teklif.Id = 1;
            teklif.Email = "bposta@xktemlak.com";
            teklif.Faks = "0(312) 011 22 33";
            teklif.Firma = "XKT EMLAK";
            teklif.GecerlilikSuresi = new DateTime().AddDays(15);
            teklif.MusteriTemsilcisi = "İsmail H. Akdoğan";
            teklif.TeklifNo = "1";
            teklif.TeklifTarihi = DateTime.Now.AddDays(2);
            teklif.Telefon = "0312 011 22 44";
            teklif.TemsilciEmail = "ihakdogan@göralfilokiralama.com";
            teklif.TemsilciTelefon = "0(312) 207 45 45";
            teklif.Yetkili = "XKT EMLAK";
            teklif.YillikKmSiniri = 50000;
            teklif.ListTeklifArac = new List<TeklifArac>()
            {
                new TeklifArac(){Birim = Tanimlar.DovizKur.Euro,Id = 1,ModelId = 1,OpsiyonOzellikleri = "2008 Active 1.6 e-HDI ETG6 92 HP Stop&Start",TeklifId = 1,Tutar = 1500,Vade = 36}
            };
            Teklifler.Add(teklif);

            teklif = new Teklif();
            teklif.Id = 2;
            teklif.Email = "aposta@yeppa.com";
            teklif.Faks = "0(312) 011 22 33";
            teklif.Firma = "YEPPA TURİZM";
            teklif.GecerlilikSuresi = new DateTime().AddDays(15);
            teklif.MusteriTemsilcisi = "İsmail H. Akdoğan";
            teklif.TeklifNo = "1";
            teklif.TeklifTarihi = DateTime.Now.AddDays(3);
            teklif.Telefon = "0312 011 22 44";
            teklif.TemsilciEmail = "ihakdogan@göralfilokiralama.com";
            teklif.TemsilciTelefon = "0(312) 207 45 45";
            teklif.Yetkili = "XKT EMLAK";
            teklif.YillikKmSiniri = 50000;
            teklif.ListTeklifArac = new List<TeklifArac>()
            {
                new TeklifArac(){Birim = Tanimlar.DovizKur.TL,Id = 2,ModelId = 1,OpsiyonOzellikleri = "2008 Active 1.6 e-HDI ETG6 92 HP Stop&Start",TeklifId = 1,Tutar = 2000,Vade = 36}
            };
            Teklifler.Add(teklif);

            teklif = new Teklif();
            teklif.Id = 3;
            teklif.Email = "";
            teklif.Faks = "0(312) 011 22 33";
            teklif.Firma = "XKT EMLAK";
            teklif.GecerlilikSuresi = new DateTime().AddDays(15);
            teklif.MusteriTemsilcisi = "İsmail H. Akdoğan";
            teklif.TeklifNo = "1";
            teklif.TeklifTarihi = DateTime.Now.AddDays(15);
            teklif.Telefon = "0312 011 22 44";
            teklif.TemsilciEmail = "ihakdogan@göralfilokiralama.com";
            teklif.TemsilciTelefon = "0(312) 207 45 45";
            teklif.Yetkili = "XKT EMLAK";
            teklif.YillikKmSiniri = 50000;
            teklif.ListTeklifArac = new List<TeklifArac>()
            {
                new TeklifArac(){Birim = Tanimlar.DovizKur.TL,Id = 2,ModelId = 1,OpsiyonOzellikleri = "2008 Active 1.6 e-HDI ETG6 92 HP Stop&Start",TeklifId = 1,Tutar = 1200,Vade = 36}
            };
            Teklifler.Add(teklif);

            teklif = new Teklif();
            teklif.Id = 4;
            teklif.Email = "";
            teklif.Faks = "0(312) 011 22 33";
            teklif.Firma = "XKT EMLAK";
            teklif.GecerlilikSuresi = new DateTime().AddDays(15);
            teklif.MusteriTemsilcisi = "İsmail H. Akdoğan";
            teklif.TeklifNo = "1";
            teklif.TeklifTarihi = DateTime.Now.AddDays(8);
            teklif.Telefon = "0312 011 22 44";
            teklif.TemsilciEmail = "ihakdogan@göralfilokiralama.com";
            teklif.TemsilciTelefon = "0(312) 207 45 45";
            teklif.Yetkili = "XKT EMLAK";
            teklif.YillikKmSiniri = 50000;
            teklif.ListTeklifArac = new List<TeklifArac>()
            {
                new TeklifArac(){Birim = Tanimlar.DovizKur.TL,Id = 2,ModelId = 1,OpsiyonOzellikleri = "2008 Active 1.6 e-HDI ETG6 92 HP Stop&Start",TeklifId = 1,Tutar = 900,Vade = 36}
            };
            Teklifler.Add(teklif);
            #endregion

            #region Döviz
            
            #endregion

            #region Teklif Araç

            #endregion
        }
    }
}
