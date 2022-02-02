using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
   
    public class IlanDal : IIlanDal
    {
        List<Ilan> _ilans = new List<Ilan>();
      
        public void Add(Ilan entity)
        {
            _ilans.Add(entity);
        }

       

        public List<Ilan> Sirala()
        {
            return _ilans;
        }
    }
}
