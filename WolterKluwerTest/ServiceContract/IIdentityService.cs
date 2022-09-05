using WolterKluwerTest.ModelsResponse;
using WolterKluwerTest.RequestModels;

namespace WolterKluwerTest.ServiceContract
{
    public interface IIdentityService
    {
        ResponseCreateIdentity? CreateIdentity(RequestIdentity requestIdentity, string? token);
        string DeleteIdentity(string email, string? token);

    }
}
