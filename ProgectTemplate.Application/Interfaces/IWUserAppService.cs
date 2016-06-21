using ProgectTemplate.Business.Entity.Table;
using System.Collections.Generic;
using ProgectTemplate.Application.ViewModel;

namespace ProgectTemplate.Application.Interfaces
{
    public interface IWUserAppService 
    {
        IEnumerable<WUserViewModel> GetAll(); 
    }
}
