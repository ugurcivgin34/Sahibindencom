using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Dizustu :Bilgisayar, IEntity
    {
        public int Id { get; set; }
        public float Agirlik { get; set; }
        public string EkranBoyutu { get; set; }
        public Kategori Kategori { get; set; }

    }
}
