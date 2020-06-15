using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;
using ResidentVulnerabilitiesApi.V1.Boundary.Responses;
using ResidentVulnerabilitiesApi.V1.Controllers;
using ResidentVulnerabilitiesApi.V1.UseCase.Interfaces;
using FluentAssertions;

namespace ResidentVulnerabilitiesApi.Tests.V1.Controllers
{
    public class ResidentVulnerabilitiesTests : Controller
    {
        private ResidentVulnerabilitiesController _classUnderTest;
        private Mock<IGetResidentByIdUseCase> _mockGetResidentByIdUseCase;
        [SetUp]
        public void Setup()
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
