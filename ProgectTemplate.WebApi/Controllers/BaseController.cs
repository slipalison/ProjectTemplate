using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

using System.Web.Mvc;

namespace ProgectTemplate.WebApi.Controllers
{
    public class BaseController : Controller
    {
        public BaseController() : base()
        {
        }

        protected virtual Task<ActionResult> TaskResult(object result)
        {
            var tsc = new TaskCompletionSource<ActionResult>();
            tsc.SetResult(View(result));
            return tsc.Task;
        }

        protected virtual Task<ActionResult> TaskResult()
        {
            var tsc = new TaskCompletionSource<ActionResult>();
            tsc.SetResult(View());
            return tsc.Task;
        }
    }
}