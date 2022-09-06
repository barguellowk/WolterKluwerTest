using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WolterKluwerTest.Request;
using WolterKluwerTest.RequestModels;
using WolterKluwerTest.ServiceContract;

namespace WolterKluwerTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MemberController : ControllerBase
    {
        private readonly IMemberService _iMemberservice;
        private readonly Token? Token;

        public MemberController(IMemberService iMemberservice)
        {
            _iMemberservice = iMemberservice;
            Token = TokenService.Token;
        }

        [HttpPost("CreateMember")]
        public ActionResult CreateMember(RequestMember requestMember)
        {
            return Ok(_iMemberservice.CreateMember(requestMember, Token?.AccessToken));
        }

        [HttpDelete("DeleteMember")]
        public ActionResult DeleteMember(string idMember)
        {
            return Ok(_iMemberservice.DeleteMember(idMember, Token?.AccessToken));
        }
    }
}
