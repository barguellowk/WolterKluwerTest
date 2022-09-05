using Microsoft.AspNetCore.Mvc;
using System.Text;
using System;
using System.Net.Http.Headers;
using System.Globalization;
using System.Security.Principal;
using WolterKluwerTest.RequestModels;

namespace WolterKluwerTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FlowAuthorizeController : ControllerBase
    {
        private readonly ILogger<FlowAuthorizeController> _logger;
        //private string redirect = "https://localhost:7094/FlowAuthorize/TestRedirectUri";
        //private string client_id = "becquer.arguello";

        public FlowAuthorizeController(ILogger<FlowAuthorizeController> logger)
        {
            _logger = logger;
        }

        [HttpGet("Start")]
        public ActionResult Start(string client_id, string scope,string responseType, string mode, string redirectUri)
        {
            //var mode = "form_post";
            //var responseType = "code";
            //var scope = "openid";
            var url = $"https://logindev.wolterskluwercloud.com/auth/core/connect/authorize?client_id={client_id}&scope={scope}&response_type={responseType}&response_mode={mode}&redirect_uri={redirectUri}";
            return Redirect(url);
        }

        [HttpPost("TestRedirectUri")]
        public string TestRedirectUri([FromForm] string code)
        {
            //var uriToken = "https://login-stg.wolterskluwer.eu/auth/core/connect/token";
            var uriToken = "https://logindev.wolterskluwercloud.com/auth/core/connect/token";
            var parameters = new Dictionary<string, string>();
            parameters.Add("grant_type", "client_credentials");
            parameters.Add("client_id", "becquer.arguello");
            parameters.Add("client_secret", "123456");
            parameters.Add("redirect_uri", "https://localhost:7094/FlowAuthorize/TestRedirectUri");
            parameters.Add("code", code);

            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.PostAsync(uriToken, new FormUrlEncodedContent(parameters)).Result;
                return response.Content.ReadAsStringAsync().Result;
            }
        }
    }
}