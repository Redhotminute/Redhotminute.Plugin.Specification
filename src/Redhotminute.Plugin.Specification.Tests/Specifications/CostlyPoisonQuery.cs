using System;
using System.Linq.Expressions;
using Redhotminute.Plugin.Specification.Tests.Models;

namespace Redhotminute.Plugin.Specification.Tests.Specifications
{
    public class CostlyPoisonQuery : Specification<Poison>
    {
        private readonly bool _isCostly;

        public CostlyPoisonQuery(bool isCostly)
        {
            _isCostly = isCostly;
        }

        public override Expression<Func<Poison, bool>> ToExpression()
        => poison => poison.IsCostly == _isCostly;
    }
}
