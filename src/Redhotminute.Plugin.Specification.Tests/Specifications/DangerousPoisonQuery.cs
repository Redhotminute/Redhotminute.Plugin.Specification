using System;
using System.Linq.Expressions;
using Redhotminute.Plugin.Specification.Tests.Models;

namespace Redhotminute.Plugin.Specification.Tests.Specifications
{
    public class DangerousPoisonQuery : Specification<Poison>
    {
        private readonly bool _isDangerous;

        public DangerousPoisonQuery(bool shouldBeDangerous)
        {
            _isDangerous = shouldBeDangerous;
        }

        public override Expression<Func<Poison, bool>> ToExpression() 
        => poison => poison.IsDangerous == _isDangerous;
    }
}
