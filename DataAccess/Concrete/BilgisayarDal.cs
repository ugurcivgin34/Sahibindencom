using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
   
    public class BilgisayarDal : IBilgisayarDal
    {
        List<Bilgisayar> _bilgisayars = new List<Bilgisayar>();
        public void Add(Bilgisayar entity)
        {
            _bilgisayars.Add(entity);
        }

        public List<Bilgisayar> Sirala()
        {
            return _bilgisayars;
        }
    }
}
