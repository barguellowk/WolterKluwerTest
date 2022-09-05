using WolterKluwerTest.ModelsResponse;
using WolterKluwerTest.RequestModels;

namespace WolterKluwerTest.ServiceContract
{
    public interface IAppService
    {
        ResponseCreateApp? CreateApp(RequestApp requestApp, string? token);
        string DeleteApp(string idApplication, string? token);
    }
}
