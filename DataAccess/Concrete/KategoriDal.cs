using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class KategoriDal : IKategoriDal
    {
        List<Kategori> _kategoriDals;
       

        public KategoriDal()
        {
          
            _kategoriDals = new List<Kategori>()
            {
                new Kategori{Id=1,CategoryName="Masa Üstü"},
                 new Kategori{Id=2,CategoryName="Diz Üstü"},
                  new Kategori{Id=3,CategoryName="Temizlik Malzemeleri"},
            };
        }
        public void Add(Kategori entity)
        {
            throw new NotImplementedException();
        }

        public List<Kategori> Sirala()
        {
            return _kategoriDals;
        }
    }
}
