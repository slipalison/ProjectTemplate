using System.Web.Mvc;
using ProgectTemplate.Application.Interfaces;
using System.Threading.Tasks;
using System;

namespace ProgectTemplate.WebApi.Controllers
{
    public class HomeController : BaseController
    {

        public readonly IWUserAppService _userApp;

        public HomeController(IWUserAppService userApp)
        {
            _userApp = userApp;
        }

        public Task<ActionResult> Index()
        {
            ViewBag.Title = "Home Page";
           var t = _userApp.GetAll();
            return TaskResult();
        }
        public Task<ActionResult> Err()
        {
            throw new Exception("Teste Elmah");
            var t = _userApp.GetAll();
            return TaskResult();
        }

    }
}
