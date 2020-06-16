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
        public void CanBeCreatedFromDatabase()
        {
            var databasePerson = new Person();
            var domainPerson = databasePerson.ToDomain();

            databasePerson.Id.Should().Be(domainPerson.Id);
            databasePerson.DateCreated.Should().BeSameDateAs(domainPerson.DateCreated);
            databasePerson.ReceivesCouncilTaxReduction.Should().Be(domainPerson.ReceivesCouncilTaxReduction);
            databasePerson.AscCases.Should().Be(domainPerson.AscCases);
            databasePerson.CscCases.Should().Be(domainPerson.CscCases);
            databasePerson.LivingInTemporaryAccommodation.Should().Be(domainPerson.LivingInTemporaryAccommodation);
            databasePerson.LowIncome.Should().Be(domainPerson.LowIncome);
            databasePerson.ChildWithSEND.Should().Be(domainPerson.ChildWithSEND);
            databasePerson.SingleParent.Should().Be(domainPerson.SingleParent);
            databasePerson.LearningDisability.Should().Be(domainPerson.LearningDisability);
        }
    }
}
