using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IIlanService
    {
        void Ekle(Ilan ilan);
        List<Ilan> Sirala();
    }
}
