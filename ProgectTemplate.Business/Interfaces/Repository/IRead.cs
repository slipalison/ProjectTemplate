using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgectTemplate.Business.Interfaces.Repository
{
    public interface IRead<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
    }
}
