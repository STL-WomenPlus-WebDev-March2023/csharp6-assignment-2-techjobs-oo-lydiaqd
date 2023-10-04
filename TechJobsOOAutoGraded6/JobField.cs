using System;
namespace TechJobsOOAutoGraded6
{
	public abstract class JobField ///Id
	{
        public int Id { get; set; }
        private static int nextId = 1;
        public string Value { get; set; }

        public JobField()
        {
            Id = nextId;
            nextId++;
        }

        public JobField(string value) : this() ///return Value
        {
            Value = value;
        }

        public override string ToString()
        {
            return Value;
        }

        public override int GetHashCode() ///Hashcode
        {
            return HashCode.Combine(Id);
        }

        public override bool Equals(object obj) ///Equals
        {
            return obj is JobField jobfield &&
                   Id == jobfield.Id;
        }

    }
}

