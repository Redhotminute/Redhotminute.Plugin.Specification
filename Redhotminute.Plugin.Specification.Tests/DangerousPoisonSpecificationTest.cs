using System.Linq;
using FluentAssertions;
using Redhotminute.Plugin.Specification.Tests.Helpers;
using Redhotminute.Plugin.Specification.Tests.Specifications;
using Xunit;

namespace Redhotminute.Plugin.Specification.Tests
{
    public class DangerousPoisonSpecificationTest
    {
        [Fact]
        public void ReturnDangerousPoisonTest()
        {
            var query = new DangerousPoisonQuery(true);

            var result = TestDataHelper.Samples
                                       .AsQueryable()
                                       .Where(query.ToExpression());

            result.Should()
                  .NotBeNullOrEmpty()
                  .And
                  .HaveCount(3);
        }

        [Fact]
        public void ReturnNotDangerousSamplesTest()
        {
            var query = new DangerousPoisonQuery(false);

            var result = TestDataHelper.Samples
                                       .AsQueryable()
                                       .Where(query.ToExpression());

            result.Should()
                  .NotBeNullOrEmpty()
                  .And
                  .HaveCount(3);
        }
    }
}
