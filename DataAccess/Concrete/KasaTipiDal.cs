using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class KasaTipiDal : IKasaTipiDal
    {
        List<KasaTipi> _kasaTipis;

        public KasaTipiDal()
        {
            _kasaTipis = new List<KasaTipi>
            {
                new KasaTipi{Id=1,KasaIsmi="Dikey"},
                new KasaTipi{Id=2,KasaIsmi="Yatay"},
                new KasaTipi{Id=3,KasaIsmi ="Thin Client"}

            };
        }
        public void Add(KasaTipi entity)
        {
            throw new NotImplementedException();
        }

        public List<KasaTipi> Sirala()
        {
            return _kasaTipis;
        }
    }
}
