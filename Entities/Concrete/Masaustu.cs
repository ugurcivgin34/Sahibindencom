using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    //public enum KasaTipi
    //{
    //    Dikey,
    //    Yatay,
    //    ThinClient
    //}
    public class Masaustu :Bilgisayar,IEntity
    {
        public int Id { get; set; }
        public KasaTipi KasaTipi { get; set; }
        public bool MonitorVarMi { get; set; }


    }
}
