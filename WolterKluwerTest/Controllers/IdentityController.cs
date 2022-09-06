using Microsoft.AspNetCore.Mvc;
using WolterKluwerTest.Request;
using WolterKluwerTest.RequestModels;
using WolterKluwerTest.ServiceContract;

namespace WolterKluwerTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IdentityController : ControllerBase
    {
        private readonly IIdentityService _iIdentityService;
        private readonly Token? Token;
        public IdentityController(IIdentityService iIdentityService)
        {
            _iIdentityService = iIdentityService;
            Token = TokenService.Token;
        }

        [HttpPost("CreateIdentity")]
        public ActionResult CreateIdentity(RequestIdentity requestIdentity) 
        {
            return Ok(_iIdentityService.CreateIdentity(requestIdentity, Token?.AccessToken));
        }

        [HttpDelete("DeleteIdentity")]
        public ActionResult DeleteIdentity(string email)
        {
            return Ok(_iIdentityService.DeleteIdentity(email, Token?.AccessToken));
        }
    }
}
