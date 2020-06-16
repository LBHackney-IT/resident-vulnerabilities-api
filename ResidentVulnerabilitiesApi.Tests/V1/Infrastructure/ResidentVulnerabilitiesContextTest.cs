using System.Linq;
using AutoFixture;
using FluentAssertions;
using NUnit.Framework;
using ResidentVulnerabilitiesApi.Tests.V1.Helper;
using ResidentVulnerabilitiesApi.V1.Infrastructure;

namespace ResidentVulnerabilitiesApi.Tests.V1.Infrastructure
{
    [TestFixture]
    public class ResidentVulnerabilitiesContextTest : DatabaseTests
    {
        [Test]
        public void CanGetAPersonFromTheDatabase()
        {
            var resident = new Fixture().Create<Resident>();

            DatabaseContext.Add(resident);
            DatabaseContext.SaveChanges();

            var result = DatabaseContext.ResidentInformation.ToList().FirstOrDefault();

            resident.Should().BeEquivalentTo(result);
        }
    }
}
