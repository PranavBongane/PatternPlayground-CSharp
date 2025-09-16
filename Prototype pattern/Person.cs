using System;

namespace Prototype_pattern
{
    public class Person : ICloneable
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Address? Address { get; set; }

        public Person(string name, int age, Address address)
        {
            Name = name;
            Age = age;
            Address = address;
        }

        // ICloneable.Clone() -> default shallow copy
        public object Clone()
        {
            return this.MemberwiseClone(); // Copies top-level only
        }

        // Manual shallow clone via constructor
        public Person shallowClone()
        {
            return new Person(this.Name, this.Age, this.Address);
        }

        // Deep clone with new Address instance
        public Person deepClone()
        {
            return new Person(this.Name, this.Age,
                new Address(this.Address?.City, this.Address?.Country));
        }

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}, Address: {Address?.City}, {Address?.Country}";
        }
    }

    public class Address
    {
        public string? City { get; set; }
        public string? Country { get; set; }

        public Address(string? city, string? country)
        {
            City = city;
            Country = country;
        }
    }
}
