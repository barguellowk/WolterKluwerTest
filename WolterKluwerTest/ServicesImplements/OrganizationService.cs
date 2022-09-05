using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using WolterKluwerTest.ModelsHelpers;
using WolterKluwerTest.ModelsResponse;
using WolterKluwerTest.Request;
using WolterKluwerTest.RequestModels;
using WolterKluwerTest.ServiceContract;

namespace WolterKluwerTest.ServicesImplements
{
    public class OrganizationService : IOrganizationService
    {
        public ResponseOrganization? CreateOrganization(Requestorganization requestorganization, string? token)
        {
            var responseOrganization = new ResponseOrganization();
            if (token != null)
            {
                var uri = UriConts.uriBaseApiDev + "organizationalunits/";

                var response = RequestService.DoPostRequest(uri, token, requestorganization);
                var value = response.Content.ReadAsStringAsync().Result;

                if (response.IsSuccessStatusCode)
                {
                    responseOrganization = JsonConvert.DeserializeObject<ResponseOrganization>(value);
                }
                else
                {
                    responseOrganization.Error = value;
                }
            }
            else
            {
                responseOrganization.Error = "Token is null";
            }

            return responseOrganization;
        }

        public string DeleteOrganization(string idOrganization, string? token)
        {
            if (token != null)
            {
                var uri = $"{UriConts.uriBaseApiDev}organizationalunits/{idOrganization}";
                var response = RequestService.DoDeleteRequest(uri, token);
                return response.Content.ReadAsStringAsync().Result;
            }

            return "Token is null";
        }
    }
}
