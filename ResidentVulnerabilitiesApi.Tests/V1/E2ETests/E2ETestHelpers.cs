using AutoFixture;
using ResidentVulnerabilitiesApi.Tests.V1.Helper;
using ResidentVulnerabilitiesApi.V1.Infrastructure;

namespace ResidentVulnerabilitiesApi.Tests.V1.E2ETests
{
    public static class E2ETestHelpers
    {
        public static Resident AddResidentWithRelatedEntitiesToDb(ResidentVulnerabilitiesContext context)
        {
            var resident = new Fixture().Create<Resident>();

            context.ResidentInformation.Add(resident);
            context.SaveChanges();

            return resident;
        }
    }
}
