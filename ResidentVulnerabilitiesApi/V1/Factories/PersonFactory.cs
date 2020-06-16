using ResidentVulnerabilitiesApi.V1.Boundary.Responses;
using ResidentVulnerabilitiesApi.V1.Domain;
using ResidentVulnerabilitiesApi.V1.Infrastructure;

namespace ResidentVulnerabilitiesApi.V1.Factories
{
    public static class PersonFactory
    {
        public static Domain.Person ToDomain(this Infrastructure.Person person)
        {
            return new Domain.Person
            {
                Id = person.Id,
                DateCreated = person.DateCreated,
                HealthConditionOrDisability = person.HealthConditionOrDisability,
                ReceivesCouncilTaxReduction = person.ReceivesCouncilTaxReduction,
                AscCases = person.AscCases,
                CscCases = person.CscCases,
                LivingInTemporaryAccommodation = person.LivingInTemporaryAccommodation,
                LowIncome = person.LowIncome,
                ChildWithSEND = person.ChildWithSEND,
                SingleParent = person.SingleParent,
                LearningDisability = person.LearningDisability,
            };
        }
    }
}
