using Microsoft.AspNetCore.Mvc;
using WolterKluwerTest.Request;
using WolterKluwerTest.RequestModels;
using WolterKluwerTest.ServiceContract;

namespace WolterKluwerTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppController : ControllerBase
    {
        private readonly IAppService _iAppservice;
        private readonly Token? Token;

        public AppController(IAppService iAppservice)
        {
            _iAppservice = iAppservice;
            Token = TokenService.Token;
        }

        [HttpPost("CreateApp")]
        public ActionResult CreateApp(RequestApp requestApp)
        {
            return Ok(_iAppservice.CreateApp(requestApp, Token?.AccessToken));
        }

        [HttpDelete("DeleteApp")]
        public ActionResult DeleteApp(string idApplication)
        {
            return Ok(_iAppservice.DeleteApp(idApplication, Token?.AccessToken));
        }
    }
}
