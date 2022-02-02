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
    public class DizustuManager : IDizustuService
    {
        private IDizustuDal _dizustuDal;
        private IKategoryService _kategoryService;

       

        public DizustuManager(IDizustuDal dizustuDal, IKategoryService kategoryService)
        {
            _dizustuDal = dizustuDal;
            _kategoryService = kategoryService;
        }

        public void Ekle(Dizustu dizustu)
        {
            _dizustuDal.Add(dizustu);
        }

        public List<Dizustu> Sirala()
        {
            return _dizustuDal.Sirala();
        }
        public Kategori KategoriBul(int id)
        {
            Kategori ifade = null;
            foreach (var item in _kategoryService.Sırala())
            {
                if (item.Id == id)
                {
                    ifade = item;
                }
            }
            return ifade;
        }
    }
}
