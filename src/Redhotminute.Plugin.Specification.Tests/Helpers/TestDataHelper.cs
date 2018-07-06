using System.Collections.Generic;
using Redhotminute.Plugin.Specification.Tests.Models;

namespace Redhotminute.Plugin.Specification.Tests.Helpers
{
    public static class TestDataHelper
    {
        public static List<Poison> Samples => new List<Poison>
        {
            new Poison(1, "NonLethalCheapPoison", false, false),
            new Poison(2, "DeadlyCheapPoison", true, false),
            new Poison(3, "NonLethalExpensivePoison", false, true),
            new Poison(4, "DeadlyExpensivePoison", true, true),
            new Poison(5, "AnotherNonLethalCheapPoison", false, false),
            new Poison(6, "AnotherDeadlyExpensivePoison", true, true)
        };
    }
}
