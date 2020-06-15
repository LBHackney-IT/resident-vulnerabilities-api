using ResidentVulnerabilitiesApi.V1.Boundary.Responses;
using ResidentVulnerabilitiesApi.V1.Domain;
using ResidentVulnerabilitiesApi.V1.Factories;
using ResidentVulnerabilitiesApi.V1.Infrastructure;

namespace ResidentVulnerabilitiesApi.V1.Gateways
{
    public class ResidentVulnerabilitiesGateway : IResidentVulnerabilitiesGateway
    {
        private readonly ResidentVulnerabilitiesContext _databaseContext;

        public ResidentVulnerabilitiesGateway(ResidentVulnerabilitiesContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public ResidentInformation GetResidentById(int id)
        {
           var result = _databaseContext.Persons.Find(id);

            /*return (result != null) ?
                result.ToDomain() :
                null;*/
            return new ResidentInformation();
        }
    }
}
