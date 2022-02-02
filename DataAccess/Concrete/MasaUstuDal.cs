using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class MasaUstuDal : IMasaUstuDal
    {
        List<Masaustu> _masaUstus = new List<Masaustu>();

      
        public void Add(Masaustu entity)
        {
            _masaUstus.Add(entity);
        }

        public List<Masaustu> Sirala()
        {
            return _masaUstus;
        }
    }
}
