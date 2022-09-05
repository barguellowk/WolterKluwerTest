using WolterKluwerTest.ModelsResponse;
using WolterKluwerTest.RequestModels;

namespace WolterKluwerTest.ServiceContract
{
    public interface IOrganizationService
    {
        ResponseOrganization? CreateOrganization(Requestorganization requestorganization, string? token);
        string DeleteOrganization(string idOrganization, string? token);
    }
}
