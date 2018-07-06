namespace Redhotminute.Plugin.Specification.Tests.Models
{
    public class Poison
    {
        public int Id { get; }

        public string Name { get; }

        public bool IsDangerous { get; }

        public bool IsCostly { get; }

        public Poison(int id, string name, bool isDangerous, bool isCostly)
        {
            Id = id;
            Name = name;
            IsDangerous = isDangerous;
            IsCostly = isCostly;
        }
    }
}
