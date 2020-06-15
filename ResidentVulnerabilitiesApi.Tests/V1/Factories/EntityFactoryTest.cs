using FluentAssertions;
using NUnit.Framework;
using ResidentVulnerabilitiesApi.V1.Factories;
using ResidentVulnerabilitiesApi.V1.Infrastructure;

namespace ResidentVulnerabilitiesApi.Tests.V1.Factories
{
    [TestFixture]
    public class EntityFactoryTest
    {
        [Test]
        public void CanBeCreatedFromDatabaseEntity()
        {
            var person = new Person();
            var entity = person.ToDomain();

            person.Id.Should().Be(entity.Id);
            person.CreatedAt.Should().BeSameDateAs(entity.CreatedAt);
        }
    }
}
