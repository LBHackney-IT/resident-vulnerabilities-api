using System.Linq;
using NUnit.Framework;
using ResidentVulnerabilitiesApi.Tests.V1.Helper;
using ResidentVulnerabilitiesApi.V1.Infrastructure;

namespace ResidentVulnerabilitiesApi.Tests.V1.Infrastructure
{
    [TestFixture]
    public class ResidentVulnerabilitiesContextTest : DatabaseTests
    {
        [Test]
        [Ignore("TODO")]
        public void CanGetADatabaseEntity()
        {
            var databaseEntity = TestHelper.CreateDatabasePersonEntity();

            DatabaseContext.Add(databaseEntity);
            DatabaseContext.SaveChanges();

            //var result = DatabaseContext..ToList().FirstOrDefault();

            //Assert.AreEqual(result, databaseEntity);
        }
    }
}
