using AutoFixture;
using ResidentVulnerabilitiesApi.V1.Domain;
using ResidentVulnerabilitiesApi.V1.Infrastructure;

namespace ResidentVulnerabilitiesApi.Tests.V1.Helper
{
    public static class TestHelper
    {
        public static ResidentVulnerabilitiesApi.V1.Infrastructure.Person CreateDatabasePerson()
        {
            var person = new Fixture().Create<ResidentVulnerabilitiesApi.V1.Infrastructure.Person>();

            return new ResidentVulnerabilitiesApi.V1.Infrastructure.Person
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
                LearningDisability = person.LearningDisability
            };
        }
    }
}
