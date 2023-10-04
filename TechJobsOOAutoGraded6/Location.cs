﻿using System;
namespace TechJobsOOAutoGraded6
{
	public class Location
	{
        public int Id { get; set; }
        private static int nextId = 1;
        public string Value { get; set; }

        public Location()
        {
            Id = nextId;
            nextId++;
        }

        // TODO: Task 2: Add a second constructor to this class that uses the Location() constructor and sets the value of the value field.

        public Location(string Value): this()
        {
            this.Value = Value;
        }

        public override bool Equals(object obj)
        {
            return obj is Location location &&
                   Id == location.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            return Value;
        }

        public static implicit operator Location(string v)
        {
            throw new NotImplementedException();
        }
    }
}

