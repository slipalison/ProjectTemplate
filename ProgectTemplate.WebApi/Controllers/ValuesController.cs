using System;
using ProgectTemplate.Application.Interfaces;
using ProgectTemplate.JsonCompression;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace ProgectTemplate.WebApi.Controllers
{
    [RoutePrefix("api/Values")]
    public class ValuesController : BaseApiController
    {
        private readonly IWUserAppService _userApp;
        public ValuesController(IWUserAppService userApp)
        {
            _userApp = userApp;
        }

        [HttpGet, Route("getdata"), DeflateCompression]
        public async Task<HttpResponseMessage> Get()
        {
            return await TaskHttpResponseMessage(HttpStatusCode.OK, _userApp.GetAll());
        }

        [HttpGet, Route("getdatabyid"), DeflateCompression]
        public Task<HttpResponseMessage> Get(int id)
        {
            return TaskHttpResponseMessage(HttpStatusCode.OK, "value");
        }



        [HttpGet, Route("err"), DeflateCompression]
        public Task<HttpResponseMessage> Err()
        {
            try
            {
                throw new Exception("teste Elmah VAI! ");
            }
            catch (Exception ex)
            {

                throw ex;
                return TaskHttpResponseMessage(HttpStatusCode.BadRequest, ex);
            }
        }
       
    }
}
