using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WolterKluwerTest.Request;
using WolterKluwerTest.RequestModels;
using WolterKluwerTest.ServiceContract;

namespace WolterKluwerTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly IRoleService _iRoleService;
        private readonly Token? Token;
        public RoleController(IRoleService iRoleService)
        {
            _iRoleService = iRoleService;
            Token = TokenService.Token;
        }

        [HttpPost("CreateRole")]
        public ActionResult CreateRole(RequestRole requestRole, string memberId) 
        {
            return Ok(_iRoleService.CreateRole(requestRole, memberId, Token?.AccessToken));
        }
    }
}
