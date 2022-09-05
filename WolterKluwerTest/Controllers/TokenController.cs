using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WolterKluwerTest.Request;
using WolterKluwerTest.RequestModels;

namespace WolterKluwerTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TokenController : ControllerBase
    {
        [HttpPost("GenerateToken")]
        public ActionResult GenerateToken(RequestToken requestToken)
        {
            TokenService.GetToken(requestToken);
            var token = TokenService.Token;
            if (token != null && token.HasError)
            {
                return Ok("Token Error :" + token.Error);
            }
            else
            {
                return Ok("Token generate correctly");
            }
        }
    }
}
