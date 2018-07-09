# Redhotminute.Plugin.Specification



[![Nuget status](https://buildstats.info/nuget/Redhotminute.Plugin.Specification)](https://www.nuget.org/packages/Redhotminute.Plugin.Specification/)

**I have decided to discontinue developing this library. While trying to implement a sort mechanism I found the following library which does exactly what I need: [https://www.nuget.org/packages?q=linqbuilder](https://www.nuget.org/packages?q=linqbuilder).**

Package based on the [Specifications pattern](https://en.wikipedia.org/wiki/Specification_pattern). I did not implement all methods since I haven't used them. 



# Get started

Install the Nuget package in your project(s).

```
Install-Package Redhotminute.Plugin.Specification
```

Create your first specication:

```
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
```

Execute the query on a list:

```
var result = TestDataHelper.Samples
                           .AsQueryable()
                           .Where(query.ToExpression());
```

See the unit-test project for a full working example.
