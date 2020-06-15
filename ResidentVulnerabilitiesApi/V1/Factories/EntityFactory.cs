using ResidentVulnerabilitiesApi.V1.Boundary.Responses;
using ResidentVulnerabilitiesApi.V1.Domain;
using ResidentVulnerabilitiesApi.V1.Infrastructure;

namespace ResidentVulnerabilitiesApi.V1.Factories
{
    public static class EntityFactory
    {
        public static ResidentInformation ToDomain(this Person databaseEntity)
        {
            return new ResidentInformation
            {
                Id = databaseEntity.Id,
                CreatedAt = databaseEntity.CreatedAt,
            };
        }
    }
}
