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
        //private Fixture _fixture = new Fixture();
        private ResidentVulnerabilitiesGateway _classUnderTest;

        [SetUp]
        public void Setup()
        {
            _classUnderTest = new ResidentVulnerabilitiesGateway(DatabaseContext);
        }

        [Test]
        [Ignore("Not Implemented")]
        public void GatewayImplementsBoundaryInterface()
        {
            Assert.NotNull(_classUnderTest is IResidentVulnerabilitiesGateway);
        }

        [Test]
        [Ignore("Not implemented")]
        public void GetEntityByIdReturnsEmptyArray()
        {
            var response = _classUnderTest.GetResidentById(123);

            response.Should().BeNull();
        }

        [Test]
        [Ignore("Not Implemented")]
        public void GetEntityByIdReturnsCorrectResponse()
        {
            /*var entity = _fixture.Create<Entity>();
            var databaseEntity = DatabaseEntityHelper.CreateDatabaseEntityFrom(entity);

            DatabaseContext.DatabaseEntities.Add(databaseEntity);
            DatabaseContext.SaveChanges();

            var response = _classUnderTest.GetEntityById(databaseEntity.Id);

            databaseEntity.Id.Should().Be(response.Id);
            databaseEntity.CreatedAt.Should().BeSameDateAs(response.CreatedAt);*/
        }
    }
}
