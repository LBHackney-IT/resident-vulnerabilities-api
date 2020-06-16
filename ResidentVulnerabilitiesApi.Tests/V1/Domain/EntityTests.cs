using System;
using FluentAssertions;
using NUnit.Framework;
using ResidentVulnerabilitiesApi.V1.Domain;
using ResidentVulnerabilitiesApi.V1.Infrastructure;

namespace ResidentVulnerabilitiesApi.Tests.V1.Domain
{
    [TestFixture]
    public class EntityTests
    {
        [Test]
        public void EntitiesHaveAnId()
        {
            var entity = new Person();
            entity.UPRN.Should().BeGreaterOrEqualTo(0);
        }

        [Test]
        public void EntitiesHaveACreatedAt()
        {
            var entity = new Person();
            var date = new DateTime(2019, 02, 21);
            entity.DateCreated = date;

            entity.DateCreated.Should().BeSameDateAs(date);
        }
    }
}
