using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text.Json.Serialization;
using WolterKluwerTest.Request;
using WolterKluwerTest.RequestModels;

namespace WolterKluwerTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TokenController : ControllerBase
    {
        [HttpGet("GenerateToken")]
        public ActionResult GenerateToken()
        {
            RequestToken requestToken = new();
            TokenService.GetToken(requestToken);
            var token = TokenService.Token;
            if (token != null && token.HasError)
            {
                return Ok(token.Error);
            }
            else
            {
                var response = JsonConvert.SerializeObject("Token generate correctly");
                return Ok(response);
            }
        }
    }
}
