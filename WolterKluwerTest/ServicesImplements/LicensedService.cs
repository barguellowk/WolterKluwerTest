using Newtonsoft.Json;
using WolterKluwerTest.Request;
using WolterKluwerTest.RequestModels;
using WolterKluwerTest.ModelsHelpers;
using WolterKluwerTest.ServiceContract;
using WolterKluwerTest.ModelsResponse.License;

namespace WolterKluwerTest.ServicesImplements
{
    public class LicensedService : ILicensedService
    {
        public ResponseLicense? CreateLicense(RequestLicense requestLicense, string organizationId, string? token)
        {
            var licenseResponse = new ResponseLicense();
            if(token != null) 
            {
                var uri = $"{UriConts.uriBaseApiDev}organizationalunits/{organizationId}/licensedapplications";
                var response = RequestService.DoPostRequest(uri, token, requestLicense);
                var value = response.Content.ReadAsStringAsync().Result;

                if (response.IsSuccessStatusCode)
                {
                    licenseResponse = JsonConvert.DeserializeObject<ResponseLicense>(value);
                }
                else
                {
                    licenseResponse.Error = value;
                }
            }
            else 
            {
                licenseResponse.Error = "Token is null";
            }

            return licenseResponse;
        }

        public string DeleteLicense(string idMember,string idLicensed, string? token)
        {
            if (token != null)
            {
                var uri = $"{UriConts.uriBaseApiDev}organizationalunits/{idMember}/licensedapplications/{idLicensed}";
                var response = RequestService.DoDeleteRequest(uri, token);
                return response.Content.ReadAsStringAsync().Result;
            }
            return "Token is null";
        }
    }
}
