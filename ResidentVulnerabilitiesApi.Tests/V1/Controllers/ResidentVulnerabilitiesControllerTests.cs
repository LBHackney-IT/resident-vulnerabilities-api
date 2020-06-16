using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;
using ResidentVulnerabilitiesApi.V1.Boundary.Responses;
using ResidentVulnerabilitiesApi.V1.Controllers;
using ResidentVulnerabilitiesApi.V1.UseCase.Interfaces;


namespace ResidentVulnerabilitiesApi.Tests.V1.Controllers
{

    [TestFixture]
    public class ResidentVulnerabilitiesControllerTests
    {
        private ResidentVulnerabilitiesController _classUnderTest;
        private Mock<IGetResidentByUprnUseCase> _mockGetResidentByUprnUseCase;

        [SetUp]
        public void SetUp()
        {
            _mockGetResidentByUprnUseCase = new Mock<IGetResidentByUprnUseCase>();
            _classUnderTest = new ResidentVulnerabilitiesController(_mockGetResidentByUprnUseCase.Object);
        }

        [Test]
        public void ViewRecordTests()
        {
            var residentInfo = new ResidentInformation()
            {
                UPRN = "12345"
            };

            _mockGetResidentByUprnUseCase.Setup(x => x.Execute(12345)).Returns(residentInfo);
            var response = _classUnderTest.ViewRecord(12345) as OkObjectResult;

            response.Should().NotBeNull();
            response.StatusCode.Should().Be(200);
            response.Value.Should().BeEquivalentTo(residentInfo);
        }
    }
}
