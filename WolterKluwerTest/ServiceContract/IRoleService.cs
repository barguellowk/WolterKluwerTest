using WolterKluwerTest.ModelsResponse;
using WolterKluwerTest.RequestModels;

namespace WolterKluwerTest.ServiceContract
{
    public interface IRoleService
    {
        ResponseRole? CreateRole(RequestRole requestRole, string memberId, string? token);
    }
}
