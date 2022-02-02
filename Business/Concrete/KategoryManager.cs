using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
   public class KategoryManager : IKategoryService
    {
        private IKategoriDal _kategoryDal;

        public KategoryManager(IKategoriDal kategoryDal)
        {
            _kategoryDal = kategoryDal;
        }

        public List<Kategori> Sırala()
        {
            return _kategoryDal.Sirala();
        }
    }
}
