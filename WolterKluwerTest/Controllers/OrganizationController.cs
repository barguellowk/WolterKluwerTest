using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WolterKluwerTest.Request;
using WolterKluwerTest.RequestModels;
using WolterKluwerTest.ServiceContract;

namespace WolterKluwerTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrganizationController : ControllerBase
    {
        private IOrganizationService _iOrganizationService;
        private readonly Token? Token;

        public OrganizationController(IOrganizationService iOrganizationService)
        {
            _iOrganizationService = iOrganizationService;
            Token = TokenService.Token;
        }

        [HttpPost("CreateOrganization")]
        public ActionResult CreateOrganization(Requestorganization requestorganization) 
        {
            return Ok(_iOrganizationService.CreateOrganization(requestorganization, Token?.AccessToken));
        }

        [HttpDelete("DeleteOrganization")]
        public ActionResult DeleteOrganization(string idOrganization)
        {
            return Ok(_iOrganizationService.DeleteOrganization(idOrganization, Token?.AccessToken));
        }
    }
}
