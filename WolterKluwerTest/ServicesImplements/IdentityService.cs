using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WolterKluwerTest.ModelsHelpers;
using WolterKluwerTest.ModelsResponse;
using WolterKluwerTest.Request;
using WolterKluwerTest.RequestModels;
using WolterKluwerTest.ServiceContract;

namespace WolterKluwerTest.ServicesImplements
{
    public class IdentityService : IIdentityService
    {
        public ResponseCreateIdentity? CreateIdentity(RequestIdentity requestIdentity, string? token)
        {
            var responseIdentity = new ResponseCreateIdentity();
            if (token != null)
            {
                var uri = UriConts.uriBaseApiDev + "identities?directCreation=true&sync=true";

                var response = RequestService.DoPostRequest(uri, token, requestIdentity);
                var value = response.Content.ReadAsStringAsync().Result;

                if (response.IsSuccessStatusCode)
                {
                    responseIdentity = JsonConvert.DeserializeObject<ResponseCreateIdentity>(value);
                }
                else
                {
                    responseIdentity.Error = value;
                }
            }
            else
            {
                responseIdentity.Error = "Token is null";
            }

            return responseIdentity;
        }

        public string DeleteIdentity(string email, string? token)
        {
            if (token != null)
            {
                var uri = $"{UriConts.uriBaseApi}_privateapi/v1/identities/{email}";
                var response = RequestService.DoDeleteRequest(uri, token);
                return response.Content.ReadAsStringAsync().Result;
            }
            return "Token is null";
        }
    }
}
