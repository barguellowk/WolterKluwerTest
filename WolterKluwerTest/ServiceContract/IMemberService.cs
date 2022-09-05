using WolterKluwerTest.ModelsResponse.Member;
using WolterKluwerTest.RequestModels;

namespace WolterKluwerTest.ServiceContract
{
    public interface IMemberService
    {
        ResponseMember? CreateMember(RequestMember requestMember, string? token);
    }
}
