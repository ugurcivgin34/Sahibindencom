using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    //enum Kategori
    //{
    //    Masaüstü_Bilgisayar,
    //    Dizüstü_Bilgisayar,
    //    Temizlik_Ürünü
    //}
    public class Ilan : IEntity
    {
        public int Id { get; set; }
        public long IlanNo { get; set; }
        public string Baslik { get; set; }
        public DateTime IlanTarihi { get; set; }
        public double Fiyat { get; set; }
        public Kullanici Satici { get; set; }
    }
}
