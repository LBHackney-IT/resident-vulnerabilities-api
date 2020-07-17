using AutoFixture;
using FluentAssertions;
using NUnit.Framework;
using ResidentVulnerabilitiesApi.V1.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ResidentVulnerabilitiesApi.Tests.V1.E2ETests
{
    [TestFixture]
    public class GetResidentInformationByUPRN : IntegrationTests<Startup>
    {
        private IFixture _fixture;

        [SetUp]
        public void SetUp()
        {
            _fixture = new Fixture();
        }

        [Test]
        public async Task GetResidentInformationByUPRNReturnsTheCorrectInformation()
        {
            var resident = new Fixture().Build<Resident>()
                .Without(r => r.UPRN)
                .With(r => r.DateCreated, new DateTime(637308732000000000)) //20-07-2020 20:20:00
                .Create();

            var dbEntity = DatabaseContext.ResidentInformation.Add(resident);
            DatabaseContext.SaveChanges();

            var expectedResponse = new ResidentVulnerabilitiesApi.V1.Boundary.Responses.ResidentInformation
            {
                UPRN = dbEntity.Entity.UPRN,
                DateCreated = resident.DateCreated,
                HealthConditionOrDisability = resident.HealthConditionOrDisability,
                ReceivesCouncilTaxReduction = resident.ReceivesCouncilTaxReduction,
                AdultSocialCareCases = resident.AdultSocialCareCases,
                ChildSocialCareCases = resident.ChildSocialCareCases,
                LivingInTemporaryAccommodation = resident.LivingInTemporaryAccommodation,
                LowIncome = resident.LowIncome,
                ChildWithSEND = resident.ChildWithSEND,
                SingleParent = resident.SingleParent,
                LearningDisability = resident.LearningDisability
            };

            var requestUri = new Uri($"api/v1/resident-vulnerabilities/{dbEntity.Entity.UPRN}", UriKind.Relative);
            var response = Client.GetAsync(requestUri);
            var statusCode = response.Result.StatusCode;
            statusCode.Should().Be(200);

            var content = response.Result.Content;
            var stringContent = await content.ReadAsStringAsync().ConfigureAwait(false);
            var convertedResponse = JsonConvert.DeserializeObject
                <ResidentVulnerabilitiesApi.V1.Boundary.Responses.ResidentInformation>(stringContent);

            convertedResponse.Should().BeEquivalentTo(expectedResponse);
        }

        [Test]
        public void GetResidentInformationByIdReturns404NotFound()
        {
            var requestUri = new Uri($"api/v1/resident-vulnerabilities/0", UriKind.Relative);
            var response = Client.GetAsync(requestUri);
            var statusCode = response.Result.StatusCode;
            statusCode.Should().Be(404);
        }

        [Test]
        public void GetResidentInformationByIdReturns400Error()
        {
            var requestUri = new Uri($"api/v1/resident-vulnerabilities/badrequest", UriKind.Relative);
            var response = Client.GetAsync(requestUri);
            var statusCode = response.Result.StatusCode;
            statusCode.Should().Be(400);
        }
    }
}
