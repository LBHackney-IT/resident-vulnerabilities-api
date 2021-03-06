using ResidentVulnerabilitiesApi.V1.Domain;

namespace ResidentVulnerabilitiesApi.V1.Gateways
{
    public interface IResidentVulnerabilitiesGateway
    {
        ResidentInformation GetResidentInformationByUPRN(long uprn);
    }
}
