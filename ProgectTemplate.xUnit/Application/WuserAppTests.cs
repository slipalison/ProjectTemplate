using System.Linq;
using ProgectTemplate.Application.Interfaces;
using ProgectTemplate.Repository.Context;
using Xunit;
using ProgectTemplate.Application;
using ProgectTemplate.Application.Service;
using ProgectTemplate.Repository.Repository.Table;
using ProgectTemplate.Repository.UoW;

namespace ProgectTemplate.xUnit.Application
{
    public class WuserAppTests
    {
        public readonly IWUserAppService _app;
        
        public WuserAppTests()
        {
            var cont = new Context();
            _app = new WUserAppService(new UnitOfWork(cont), new WUserRepository(cont));
            AutoMapperConfig.RegisterMappings();
        }

        [Fact]
        public void Usuario_ContaUsuarios_MaiorQueZero()
        {
            var actual = _app.GetAll();
            Assert.True(_app.GetAll().Count() > 0);
        }
    }
}
