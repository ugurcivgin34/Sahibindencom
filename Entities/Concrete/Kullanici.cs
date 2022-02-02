using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Kullanici : IEntity
    {
        public int Id { get; set; }
        public string Adsoyad { get; set; }
        public string Telefon { get; set; }
      
    }
}
