using AutoFixture;
using FluentAssertions;
using NUnit.Framework;
using ResidentVulnerabilitiesApi.Tests.V1.Helper;
using ResidentVulnerabilitiesApi.V1.Domain;
using ResidentVulnerabilitiesApi.V1.Gateways;
using ResidentVulnerabilitiesApi.V1.Infrastructure;

namespace ResidentVulnerabilitiesApi.Tests.V1.Gateways
{
    [TestFixture]
    public class ResidentVulnerabilitiesTests : DatabaseTests
    {
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
        public void GetResidentInformationByUPRNReturnsNullIfNoneExist()
        {
            var response = _classUnderTest.GetResidentInformationByUPRN(123);

            response.Should().BeNull();
        }

        [Test]
        public void GetResidentInformationByUPRNReturnsCorrectResponse()
        {
            var resident = new Fixture().Create<Resident>();

            DatabaseContext.ResidentInformation.Add(resident);
            DatabaseContext.SaveChanges();

            var response = _classUnderTest.GetResidentInformationByUPRN(resident.UPRN);

            response.Should().BeEquivalentTo(resident);
        }
    }
}
