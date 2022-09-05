using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WolterKluwerTest.ModelsHelpers;
using WolterKluwerTest.ModelsResponse;
using WolterKluwerTest.Request;
using WolterKluwerTest.RequestModels;
using WolterKluwerTest.ServiceContract;

namespace WolterKluwerTest.ServicesImplements
{
    public class AppService : IAppService
    {
        public ResponseCreateApp? CreateApp(RequestApp requestApp, string? token)
        {
            var responseApp = new ResponseCreateApp();
            if(token != null)
            {
                var uri = UriConts.uriBaseApiDev + "applications";

                var response = RequestService.DoPostRequest(uri, token, requestApp);
                var value = response.Content.ReadAsStringAsync().Result;

                if (response.IsSuccessStatusCode)
                {
                    responseApp = JsonConvert.DeserializeObject<ResponseCreateApp>(value);
                }
                else
                {
                    responseApp.Error = value;
                }
            }
            else 
            {
                responseApp.Error = "Token is null";
            }

            return responseApp;
        }

        public string DeleteApp(string idApplication, string? token)
        {
            if (token != null) 
            {
                var uri = $"{UriConts.uriBaseApiDev}applications/{idApplication}";
                var response = RequestService.DoDeleteRequest(uri, token);
                return response.Content.ReadAsStringAsync().Result;
            }
            else 
            {
                return "Token is null";
            }
        }
    }
}
