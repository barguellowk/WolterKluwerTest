using WolterKluwerTest.ModelsResponse.License;
using WolterKluwerTest.RequestModels;

namespace WolterKluwerTest.ServiceContract
{
    public interface ILicensedService
    {
        ResponseLicense? CreateLicense(RequestLicense requestLicense, string organizationId, string? token);
    }
}
