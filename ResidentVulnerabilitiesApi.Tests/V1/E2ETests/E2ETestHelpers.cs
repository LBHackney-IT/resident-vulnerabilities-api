using ResidentVulnerabilitiesApi.Tests.V1.Helper;
using ResidentVulnerabilitiesApi.V1.Boundary.Responses;
using ResidentVulnerabilitiesApi.V1.Infrastructure;

namespace ResidentVulnerabilitiesApi.Tests.V1.E2ETests
{
    public static class E2ETestHelpers
    {
        public static ResidentInformation AddPersonWithRelatesEntitiesToDb(ResidentVulnerabilitiesContext context)
        {
            var person = TestHelper.CreateDatabasePersonEntity();
            var addedPerson = context.Persons.Add(person);
            context.SaveChanges();
            return new ResidentInformation();
        }
    }
}
