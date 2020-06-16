using ResidentVulnerabilitiesApi.V1.Boundary.Responses;
using ResidentVulnerabilitiesApi.V1.Domain;
using ResidentVulnerabilitiesApi.V1.Infrastructure;
using ResidentInformation = ResidentVulnerabilitiesApi.V1.Domain.ResidentInformation;

namespace ResidentVulnerabilitiesApi.V1.Factories
{
    public static class EntityFactory
    {
        public static ResidentInformation ToDomain(this Person databaseEntity)
        {
            return new ResidentInformation
            {
                UPRN = databaseEntity.UPRN.ToString(),
                HealthConditionOrDisability = databaseEntity.HealthConditionOrDisability,
                ReceivesCouncilTaxReduction = databaseEntity.ReceivesCouncilTaxReduction,
                AdultSocialCareCases = databaseEntity.AdultSocialCareCases,
                ChildrenSocialCareCases = databaseEntity.ChildrenSocialCareCases,
                LivingInTemporaryAccomadation = databaseEntity.LivingInTemporaryAccomadation,
                LowIncome = databaseEntity.LowIncome,
                ChildWithSEND = databaseEntity.ChildWithSEND,
                SingleParent = databaseEntity.SingleParent,
                LearningDisability = databaseEntity.LearningDisability,
                DateCreated = databaseEntity.DateCreated.ToString("O")
            };
        }
    }
}
