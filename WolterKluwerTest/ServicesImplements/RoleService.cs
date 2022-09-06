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
    public class RoleService : IRoleService
    {
        public ResponseRole? CreateRole(RequestRole requestRole, string memberId, string? token)
        {
            var responseRole = new ResponseRole();
            if (token != null)
            {
                var uri = $"{UriConts.uriBaseApiDevRole}, members/, {memberId}, /roles";

                var response = RequestService.DoPostRequest(uri, token, requestRole);
                var value = response.Content.ReadAsStringAsync().Result;

                if (response.IsSuccessStatusCode)
                {
                    responseRole = JsonConvert.DeserializeObject<ResponseRole>(value);
                }
                else
                {
                    responseRole.Error = value;
                }
            }
            else
            {
                responseRole.Error = "Token is null";
            }
            return responseRole;
        }

        public string DeleteRole(string idMember, string idRole, string? token)
        {
            if (token != null)
            {
                var uri = $"{UriConts.uriBaseApiDevRole}members/{idMember}/roles/{idRole}";
                var response = RequestService.DoDeleteRequest(uri, token);
                return response.Content.ReadAsStringAsync().Result;
            }
            return "Token is null";
        }

    }
}
