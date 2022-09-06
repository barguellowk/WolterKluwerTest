using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WolterKluwerTest.Request;
using WolterKluwerTest.RequestModels;
using WolterKluwerTest.ServiceContract;
using WolterKluwerTest.ServicesImplements;

namespace WolterKluwerTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LicenseController : ControllerBase
    {
        private readonly ILicensedService  _iLicensedService;
        private readonly Token? Token;

        public LicenseController(ILicensedService iLicensedService)
        {
            _iLicensedService = iLicensedService;
            Token = TokenService.Token;
        }

        [HttpPost("CreateLicense")]
        public ActionResult CreateLicense(RequestLicense requestLicense, string organizationId) 
        {
            return Ok(_iLicensedService.CreateLicense(requestLicense, organizationId, Token?.AccessToken));
        }

        [HttpDelete("DeleteLicense")]
        public ActionResult DeleteLicense(string idMember, string idLicense)
        {
            return Ok(_iLicensedService.DeleteLicense(idMember, idLicense, Token?.AccessToken));
        }
    }
}
