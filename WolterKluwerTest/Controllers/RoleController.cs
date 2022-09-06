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

        [HttpDelete("DeleteRole")]
        public ActionResult DeleteRole(string memberId, string idRole)
        {
            return Ok(_iRoleService.DeleteRole(memberId, idRole, Token?.AccessToken));
        }
    }
}
