using System.Linq;
using FluentAssertions;
using Redhotminute.Plugin.Specification.Tests.Helpers;
using Redhotminute.Plugin.Specification.Tests.Specifications;
using Xunit;

namespace Redhotminute.Plugin.Specification.Tests
{
    public class DangerousAndCheepPoisonSpecificationTest
    {
        [Fact]
        public void ReturnDangerousAndCheapPoisonTest()
        {
            var query = new DangerousPoisonQuery(true).And(new CostlyPoisonQuery(false));

            var result = TestDataHelper.Samples
                                       .AsQueryable()
                                       .Where(query.ToExpression());

            result.Should()
                  .NotBeNullOrEmpty()
                  .And
                  .HaveCount(1);

            result.FirstOrDefault()
                  .Name
                  .Should()
                  .Be("DeadlyCheapPoison");
        }

        [Fact]
        public void ReturnDangerousAndExpensivePoisonTest()
        {
            var query = new DangerousPoisonQuery(true).And(new CostlyPoisonQuery(true));

            var result = TestDataHelper.Samples
                                       .AsQueryable()
                                       .Where(query.ToExpression());

            result.Should()
                  .NotBeNullOrEmpty()
                  .And
                  .HaveCount(2);
        }
    }
}
