using System.Collections.Generic;
using System.Linq;
using ProgectTemplate.Business.Interfaces.Repository.Table;
using ProgectTemplate.Business.Entity.Table;

namespace ProgectTemplate.Repository.Repository.Table
{
    public class WUserRepository : RepositoryBase<WUser>, IWUserRepository
    {
        public WUserRepository(Context.Context context) 
            : base(context) { }

        public IEnumerable<WUser> BuscaPorNome(string nome) => DbSet.Where(x => x.DsUserName.Contains(nome));

    }
}
