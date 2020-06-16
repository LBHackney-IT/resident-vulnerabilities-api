using System;
using FluentAssertions;
using NUnit.Framework;
using ResidentVulnerabilitiesApi.V1.Domain;

namespace ResidentVulnerabilitiesApi.Tests.V1.Domain
{
    [TestFixture]
    public class ResidentInformationTests
    {
        [Test]
        public void ResidentInformationIncludesUPRN()
        {
            var residentInformation = new ResidentInformation();
            residentInformation.UPRN.Should().BeGreaterOrEqualTo(0);
        }

        [Test]
        public void ResidentInformationIncludesCreatedAt()
        {
            var residentInformation = new ResidentInformation();
            var date = new DateTime(2019, 02, 21);
            residentInformation.DateCreated = date;

            residentInformation.DateCreated.Should().BeSameDateAs(date);
        }

        [Test]
        public void ResidentInformationIncludesVulnerabilityInformationt()
        {
            var residentInformation = new ResidentInformation();
            residentInformation.HealthConditionOrDisability = true;
            residentInformation.ReceivesCouncilTaxReduction = true;
            residentInformation.AdultSocialCareCases = 1;
            residentInformation.ChildSocialCareCases = 0;
            residentInformation.LivingInTemporaryAccommodation = false;
            residentInformation.LowIncome = true;
            residentInformation.ChildWithSEND = false;
            residentInformation.SingleParent = false;
            residentInformation.LearningDisability = false;

            residentInformation.HealthConditionOrDisability.Should().BeTrue();
            residentInformation.ReceivesCouncilTaxReduction.Should().BeTrue();
            residentInformation.AdultSocialCareCases.Should().Be(1);
            residentInformation.ChildSocialCareCases.Should().Be(0);
            residentInformation.LivingInTemporaryAccommodation.Should().BeFalse();
            residentInformation.LowIncome.Should().BeTrue();
            residentInformation.ChildWithSEND.Should().BeFalse();
            residentInformation.SingleParent.Should().BeFalse();
            residentInformation.LearningDisability.Should().BeFalse();
        }
    }
}
