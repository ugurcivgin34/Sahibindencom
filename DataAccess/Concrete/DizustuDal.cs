using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class DizustuDal : IDizustuDal
    {
        List<Dizustu> _dizustus = new List<Dizustu>();
        public void Add(Dizustu entity)
        {
            _dizustus.Add(entity);
        }

        public List<Dizustu> Sirala()
        {
            return _dizustus;
        }
    }
}
