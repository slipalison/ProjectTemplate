using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProgectTemplate.Business.Entity.Table;

namespace ProgectTemplate.Business.Interfaces.Repository.Table
{
    public interface IWUserRepository: IWrite<WUser>, IRead<WUser>
    {
        IEnumerable<WUser> BuscaPorNome(string nome);
    }
}
