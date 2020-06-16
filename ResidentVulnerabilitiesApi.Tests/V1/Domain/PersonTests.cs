using System;
using FluentAssertions;
using NUnit.Framework;
using ResidentVulnerabilitiesApi.V1.Domain;

namespace ResidentVulnerabilitiesApi.Tests.V1.Domain
{
    [TestFixture]
    public class PersonTests
    {
        [Test]
        public void APersonHasAnId()
        {
            var person = new Person();
            person.Id.Should().BeGreaterOrEqualTo(0);
        }

        [Test]
        public void APersonHasADate()
        {
            var person = new Person();
            var date = new DateTime(2019, 02, 21);
            person.DateCreated = date;

            person.DateCreated.Should().BeSameDateAs(date);
        }

        [Test]
        public void APersonMayHaveVulnerabilityData()
        {
            var person = new Person();

            person.HealthConditionOrDisability = true;
            person.ReceivesCouncilTaxReduction = true;
            person.AscCases = 1;
            person.CscCases = 1;
            person.LivingInTemporaryAccommodation = true;
            person.LowIncome = true;
            person.ChildWithSEND = true;
            person.SingleParent = true;
            person.LearningDisability = true;

            person.HealthConditionOrDisability.Should().BeTrue();
            person.ReceivesCouncilTaxReduction.Should().BeTrue();
            person.AscCases.Should().Be(1);
            person.CscCases.Should().Be(1);
            person.LivingInTemporaryAccommodation.Should().BeTrue();
            person.LowIncome.Should().BeTrue();
            person.ChildWithSEND.Should().BeTrue();
            person.SingleParent.Should().BeTrue();
            person.LearningDisability.Should().BeTrue();
        }
    }
}
