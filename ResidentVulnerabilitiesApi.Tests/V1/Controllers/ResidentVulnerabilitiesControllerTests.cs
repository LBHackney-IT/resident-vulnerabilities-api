using System.Collections.Generic;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;
using ResidentVulnerabilitiesApi.V1.Controllers;
using ResidentVulnerabilitiesApi.V1.UseCase.Interfaces;
using ResidentVulnerabilitiesApi.V1.UseCase;
using ResidentVulnerabilitiesApi.V1.Boundary.Responses;

namespace ResidentVulnerabilitiesApi.Tests.V1.Controllers
{

    [TestFixture]
    public class ResidentVulnerabilitiesControllerTests
    {
        private ResidentVulnerabilitiesController _classUnderTest;
        private Mock<IGetResidentByIdUseCase> _mockGetResidentByIdUseCase;

        [SetUp]
        public void SetUp()
        {
            _mockGetResidentByIdUseCase = new Mock<IGetResidentByIdUseCase>();
            _classUnderTest = new ResidentVulnerabilitiesController(_mockGetResidentByIdUseCase.Object);
        }

        [Test]
        public void ViewRecordTests()
        {
            var residentInfo = new ResidentInformation()
            {
                FirstName = "test",
                LastName = "test",
                DateOfBirth = "01/01/2020"
            };

            _mockGetResidentByIdUseCase.Setup(x => x.Execute(12345)).Returns(residentInfo);
            var response = _classUnderTest.ViewRecord(12345) as OkObjectResult;

            response.Should().NotBeNull();
            response.StatusCode.Should().Be(200);
            response.Value.Should().BeEquivalentTo(residentInfo);
        }
    }
}
