using FluentAssertions;
using NUnit.Framework;
using ResidentVulnerabilitiesApi.V1.Factories;
using ResidentVulnerabilitiesApi.V1.Infrastructure;

namespace ResidentVulnerabilitiesApi.Tests.V1.Factories
{
    [TestFixture]
    public class ResidentInformationFactoryTest
    {
        [Test]
        public void ResidentInformationCanBeCreatedFromResident()
        {
            var resident = new Resident();
            var residentInformation = resident.ToDomain();

            residentInformation.UPRN.Should().Be(resident.UPRN);
            residentInformation.DateCreated.Should().Be(resident.DateCreated);
            residentInformation.HealthConditionOrDisability.Should().Be(resident.HealthConditionOrDisability);
            residentInformation.ReceivesCouncilTaxReduction.Should().Be(resident.ReceivesCouncilTaxReduction);
            residentInformation.AdultSocialCareCases.Should().Be(resident.AdultSocialCareCases);
            residentInformation.ChildSocialCareCases.Should().Be(resident.ChildSocialCareCases);
            residentInformation.LivingInTemporaryAccommodation.Should().Be(resident.LivingInTemporaryAccommodation);
            residentInformation.LowIncome.Should().Be(resident.LowIncome);
            residentInformation.ChildWithSEND.Should().Be(resident.ChildWithSEND);
            residentInformation.SingleParent.Should().Be(resident.SingleParent);
            residentInformation.LearningDisability.Should().Be(resident.LearningDisability);
        }
    }
}
