using System;
using System.Linq.Expressions;
using Redhotminute.Plugin.Specification.Interfaces;

namespace Redhotminute.Plugin.Specification
{
    public abstract class Specification<T> : ISpecification<T>
    {
        public abstract Expression<Func<T, bool>> ToExpression();

        public bool IsSatisfiedBy(T entity)
        {
            Func<T, bool> predicate = ToExpression().Compile();
            return predicate(entity);
        }

        public ISpecification<T> And(ISpecification<T> specification)
        => new AndSpecification<T>(this, specification);

        public ISpecification<T> Or(ISpecification<T> specification)
        => new OrSpecification<T>(this, specification);
    }
}
