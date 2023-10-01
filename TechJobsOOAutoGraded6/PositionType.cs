using System;
namespace TechJobsOOAutoGraded6
{
	public class PositionType : IEquatable<PositionType?>
    {
        public int Id { get; }
        private static int nextId = 1;
        public string Value { get; set; }

        public PositionType()
        {
            Id = nextId;
            nextId++;
        }

        public PositionType(string value) : this()
        {
            Value = value;
        }

        public override string ToString()
        {
            return Value;
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as PositionType);
        }

        public bool Equals(PositionType? other)
        {
            return other is not null &&
                   Id == other.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        // TODO: Task 2: Add custom Equals(), GetHashCode(), and ToString() methods.

    }
}

