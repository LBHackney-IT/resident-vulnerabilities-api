using AutoFixture;
using ResidentVulnerabilitiesApi.V1.Domain;
using ResidentVulnerabilitiesApi.V1.Infrastructure;

namespace ResidentVulnerabilitiesApi.Tests.V1.Helper
{
    public static class TestHelper
    {
        public static Person CreateDatabasePersonEntity()
        {
            var entity = new Fixture().Create<Person>();

            return CreateDatabasePersonEntity(entity);
        }

        public static Person CreateDatabasePersonEntity(Person person)
        {
            return new Person
            {
                UPRN = person.UPRN
            };
        }
    }
}
