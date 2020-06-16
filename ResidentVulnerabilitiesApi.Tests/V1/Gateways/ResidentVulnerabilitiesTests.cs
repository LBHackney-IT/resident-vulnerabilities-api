using AutoFixture;
using FluentAssertions;
using NUnit.Framework;
using ResidentVulnerabilitiesApi.Tests.V1.Helper;
using ResidentVulnerabilitiesApi.V1.Domain;
using ResidentVulnerabilitiesApi.V1.Gateways;

namespace ResidentVulnerabilitiesApi.Tests.V1.Gateways
{
    [TestFixture]
    public class ResidentVulnerabilitiesTests : DatabaseTests
    {
        private Fixture _fixture = new Fixture();
        private ResidentVulnerabilitiesGateway _classUnderTest;

        [SetUp]
        public void Setup()
        {
            _classUnderTest = new ResidentVulnerabilitiesGateway(DatabaseContext);
        }

        [Test]
        public void GatewayImplementsBoundaryInterface()
        {
            Assert.NotNull(_classUnderTest is IResidentVulnerabilitiesGateway);
        }

        [Test]
        public void GetResidentByIdReturnsNullIfDoesntExist()
        {
            var response = _classUnderTest.GetResidentById(123);

            response.Should().BeNull();
        }

        [Test]
        public void GetResidentByIdReturnsCorrectResponse()
        {
            var databasePerson = TestHelper.CreateDatabasePerson();

            DatabaseContext.DatabaseEntities.Add(databasePerson);
            DatabaseContext.SaveChanges();

            var response = _classUnderTest.GetResidentById(databasePerson.Id);

            response.Id.Should().Be(databasePerson.Id);
            response.DateCreated.Should().BeSameDateAs(databasePerson.DateCreated);
            response.ReceivesCouncilTaxReduction.Should().Be(databasePerson.ReceivesCouncilTaxReduction);
            response.AscCases.Should().Be(databasePerson.AscCases);
            response.CscCases.Should().Be(databasePerson.CscCases);
            response.LivingInTemporaryAccommodation.Should().Be(databasePerson.LivingInTemporaryAccommodation);
            response.LowIncome.Should().Be(databasePerson.LowIncome);
            response.ChildWithSEND.Should().Be(databasePerson.ChildWithSEND);
            response.SingleParent.Should().Be(databasePerson.SingleParent);
            response.LearningDisability.Should().Be(databasePerson.LearningDisability);
        }
    }
}
