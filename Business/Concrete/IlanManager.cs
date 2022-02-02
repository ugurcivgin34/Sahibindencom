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
    public class IlanManager : IIlanService
    {
        private IIlanDal _ıILanDal;

        public IlanManager(IIlanDal ıILanDal)
        {
            _ıILanDal = ıILanDal;
        }



        public void Ekle(Ilan ilan)
        {
            _ıILanDal.Add(ilan);
        }

        public List<Ilan> Sirala()
        {
            return _ıILanDal.Sirala();
        }
    }
}
