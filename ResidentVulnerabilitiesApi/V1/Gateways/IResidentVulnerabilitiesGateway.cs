using ResidentVulnerabilitiesApi.V1.Boundary.Responses;
using ResidentVulnerabilitiesApi.V1.Domain;

namespace ResidentVulnerabilitiesApi.V1.Gateways
{
    public interface IResidentVulnerabilitiesGateway
    {
        ResidentInformation GetResidentById(int id);
    }
}
