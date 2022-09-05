using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WolterKluwerTest.ModelsHelpers;
using WolterKluwerTest.ModelsResponse.Member;
using WolterKluwerTest.Request;
using WolterKluwerTest.RequestModels;
using WolterKluwerTest.ServiceContract;

namespace WolterKluwerTest.ServicesImplements
{
    public class MemberService : IMemberService
    {
        public ResponseMember? CreateMember(RequestMember requestMember, string? token)
        {
            var memberResponse = new ResponseMember();
            if (token != null)
            {
                var uri = UriConts.uriBaseApiDev + "members/";

                var response = RequestService.DoPostRequest(uri, token, requestMember);
                var value = response.Content.ReadAsStringAsync().Result;

                if (response.IsSuccessStatusCode)
                {
                    memberResponse = JsonConvert.DeserializeObject<ResponseMember>(value);
                }
                else
                {
                    memberResponse.Error = value;
                }
            }
            else
            {
                memberResponse.Error = "Token is null";
            }

            return memberResponse;
        }
    }
}
