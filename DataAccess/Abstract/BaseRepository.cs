using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IBaseRepository<T>
    {
        void Add(T entity);
        List<T>Sirala();
    }
}
