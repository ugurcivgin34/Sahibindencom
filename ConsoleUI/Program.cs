using Business.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Kullanici kullanici = new Kullanici();
            kullanici.Id = 1;
            kullanici.Adsoyad = "Uğur Okan Çivgin";
            kullanici.Telefon = "05385839563";

            Kullanici kullanici2 = new Kullanici();
            kullanici2.Id = 2;
            kullanici2.Adsoyad = "Apo Enes";
            kullanici2.Telefon = "0353053053";

            Ilan ilan = new Ilan();
            ilan.Id = 2;
            ilan.IlanNo = 321321;
            ilan.Baslik = "Sapıklar";
            ilan.IlanTarihi = DateTime.Now;
            ilan.Fiyat = 571;
            ilan.Satici = kullanici2;

            Ilan ilan2 = new Ilan();
            ilan2.Id = 1;
            ilan2.IlanNo = 123123;
            ilan2.Baslik = "Çılgın";
            ilan2.IlanTarihi = DateTime.Now;
            ilan2.Fiyat = 123;
            ilan2.Satici = kullanici;

            DizustuManager dizustuManager = new DizustuManager(new DizustuDal(),new KategoryManager(new KategoriDal()));
            Dizustu dizustu = new Dizustu();
            dizustu.Id = 1;
            dizustu.IlanNo = 1;
            dizustu.IlanTarihi = DateTime.Now;
            dizustu.HDD = 12;
            dizustu.SSD = 1024;
            dizustu.Marka = "Hp";
            dizustu.Satici = kullanici;
            dizustu.Fiyat = 123;
            dizustu.Bellek = "amdd";
            dizustu.Agirlik = 12356;
            dizustu.EkranBoyutu = "15 inc";
            dizustu.EthernetVarMi = true;
            dizustu.WifiVarMi = true;
            dizustu.Kategori = dizustuManager.KategoriBul(1);
            dizustuManager.Ekle(dizustu);

            Dizustu dizustu2 = new Dizustu();
            dizustu2.Id = 2;
            dizustu2.IlanNo = 2;
            dizustu2.IlanTarihi = DateTime.Now;
            dizustu2.HDD = 2132;
            dizustu2.SSD = 1024;
            dizustu2.Marka = "Acer";
            dizustu2.Satici = kullanici2;
            dizustu2.Fiyat = 123;
            dizustu2.Bellek = "asas";
            dizustu2.Agirlik = 12356;
            dizustu2.EkranBoyutu = "15 inc";
            dizustu2.EthernetVarMi = true;
            dizustu2.WifiVarMi = true;
            dizustu2.Kategori = dizustuManager.KategoriBul(2);
            dizustuManager.Ekle(dizustu2);





            IlanManager ilanManager = new IlanManager(new IlanDal());
            ilanManager.Ekle(ilan);
            ilanManager.Ekle(ilan2);

            //foreach (var item in ilanManager.Sirala())
            //{
            //    Console.WriteLine(item.Satici.Adsoyad + " " + item.IlanNo);
            //}

            foreach (var item in dizustuManager.Sirala())
            {
                Console.WriteLine(item.Kategori.CategoryName + " " + item.Marka);
            }

            
        }
    }
}
