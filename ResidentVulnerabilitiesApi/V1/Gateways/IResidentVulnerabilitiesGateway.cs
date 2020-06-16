using ResidentVulnerabilitiesApi.V1.Boundary.Responses;
using ResidentVulnerabilitiesApi.V1.Domain;
using ResidentInformation = ResidentVulnerabilitiesApi.V1.Domain.ResidentInformation;

namespace ResidentVulnerabilitiesApi.V1.Gateways
{
    public interface IResidentVulnerabilitiesGateway
    {
        ResidentInformation GetResidentByUprn(int id);
    }
}
