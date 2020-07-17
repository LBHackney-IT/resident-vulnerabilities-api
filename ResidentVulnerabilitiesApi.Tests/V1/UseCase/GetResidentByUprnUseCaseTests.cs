using AutoFixture;
using FluentAssertions;
using Moq;
using NUnit.Framework;
using ResidentVulnerabilitiesApi.V1.Gateways;
using ResidentVulnerabilitiesApi.V1.UseCase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResidentVulnerabilitiesApi.Tests.V1.UseCase
{
    public class GetResidentByUprnUseCaseTests
    {
        private Mock<IResidentVulnerabilitiesGateway> _mockGateway;
        private GetResidentByUprnUseCase _classUnderTest;
        private readonly Fixture _fixture = new Fixture();

        [SetUp]
        public void SetUp()
        {
            _mockGateway = new Mock<IResidentVulnerabilitiesGateway>();
            _classUnderTest = new GetResidentByUprnUseCase(_mockGateway.Object);
        }

        [Test]
        public void ReturnsresidentInformationRecordForTheSpecifiedUPRN()
        {
            var stubbedResidentInfo = _fixture.Create<ResidentVulnerabilitiesApi.V1.Domain.ResidentInformation>();

            _mockGateway.Setup(x =>
                    x.GetResidentInformationByUPRN(1234))
                .Returns(stubbedResidentInfo);

            var response = _classUnderTest.Execute(1234);
            var expectedResponse = new ResidentVulnerabilitiesApi.V1.Boundary.Responses.ResidentInformation
            {
                UPRN = stubbedResidentInfo.UPRN,
                DateCreated = stubbedResidentInfo.DateCreated,
                HealthConditionOrDisability = stubbedResidentInfo.HealthConditionOrDisability,
                ReceivesCouncilTaxReduction = stubbedResidentInfo.ReceivesCouncilTaxReduction,
                AdultSocialCareCases = stubbedResidentInfo.AdultSocialCareCases,
                ChildSocialCareCases = stubbedResidentInfo.ChildSocialCareCases,
                LivingInTemporaryAccommodation = stubbedResidentInfo.LivingInTemporaryAccommodation,
                LowIncome = stubbedResidentInfo.LowIncome,
                ChildWithSEND = stubbedResidentInfo.ChildWithSEND,
                SingleParent = stubbedResidentInfo.SingleParent,
                LearningDisability = stubbedResidentInfo.LearningDisability
            };

            response.Should().NotBeNull();
            response.Should().BeEquivalentTo(expectedResponse);
        }

        [Test]
        public void IfGatewayReturnsNullThrowNotFoundException()
        {
            ResidentVulnerabilitiesApi.V1.Domain.ResidentInformation nullResult = null;

            _mockGateway.Setup(x =>
                    x.GetResidentInformationByUPRN(It.IsAny<long>()))
                .Returns(nullResult);

            var response = _classUnderTest.Execute(123456);
            response.Should().BeNull();
        }
    }


}
