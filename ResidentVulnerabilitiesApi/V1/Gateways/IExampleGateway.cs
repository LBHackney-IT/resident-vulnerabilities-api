using ResidentVulnerabilitiesApi.V1.Domain;

namespace ResidentVulnerabilitiesApi.V1.Gateways
{
    public interface IExampleGateway
    {
        Entity GetEntityById(int id);
    }
}
