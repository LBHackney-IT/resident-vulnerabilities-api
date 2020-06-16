using ResidentVulnerabilitiesApi.V1.Domain;
using ResidentVulnerabilitiesApi.V1.Infrastructure;

namespace ResidentVulnerabilitiesApi.V1.Factories
{
    public static class ResidentInformationFactory
    {
        public static ResidentInformation ToDomain(this Resident resident)
        {
            return new ResidentInformation
            {
                UPRN = resident.UPRN,
                DateCreated = resident.DateCreated,
                HealthConditionOrDisability = resident.HealthConditionOrDisability,
                ReceivesCouncilTaxReduction = resident.ReceivesCouncilTaxReduction,
                AdultSocialCareCases = resident.AdultSocialCareCases,
                ChildSocialCareCases = resident.ChildSocialCareCases,
                LivingInTemporaryAccommodation = resident.LivingInTemporaryAccommodation,
                LowIncome = resident.LowIncome,
                ChildWithSEND = resident.ChildWithSEND,
                SingleParent = resident.SingleParent,
                LearningDisability = resident.LearningDisability
            };
        }
    }
}
