using System.Linq;
using FluentAssertions;
using Redhotminute.Plugin.Specification.Tests.Helpers;
using Redhotminute.Plugin.Specification.Tests.Specifications;
using Xunit;

namespace Redhotminute.Plugin.Specification.Tests
{
    public class DangerousOrCheapPoisonSpecificationTest
    {
        [Fact]
        public void ReturnDangerousOrCheapPoisonTest()
        {
            var query = new DangerousPoisonQuery(true).Or(new CostlyPoisonQuery(false));

            var result = TestDataHelper.Samples
                                       .AsQueryable()
                                       .Where(query.ToExpression());

            result.Should()
                  .NotBeNullOrEmpty()
                  .And
                  .HaveCount(5);
        }

        [Fact]
        public void ReturnNonLethalOrExpensivePoisonTest()
        {
            var query = new DangerousPoisonQuery(false).Or(new CostlyPoisonQuery(true));

            var result = TestDataHelper.Samples
                                       .AsQueryable()
                                       .Where(query.ToExpression());

            result.Should()
                  .NotBeNullOrEmpty()
                  .And
                  .HaveCount(5);
        }
    }
}
