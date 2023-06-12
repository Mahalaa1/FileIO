using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIO
{
    internal class Person : IComparable
    {
        public string? FirstName { get; init; } = String.Empty;

        public string? LastName { get; init; } = String.Empty;

        public Address Address { get; init; }

        public string? Phone { get; init; } = String.Empty;
        public Person()
        {
            FirstName = String.Empty;
            LastName = String.Empty;
            Address = null;
            Phone = String.Empty;
        }

        public Person(string? firstName, string? lastName, Address address, string? phone)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            Phone = phone;
        }

        public override string ToString()
        {
            return
            " | " + $"First Name: {FirstName}" + " | " +
                $"Last Name: {LastName}  " + " | " +
                $"Address: {Address}" + " | " +
                $"Phone: {Phone}" + " | ";
        }

        public int CompareTo(object? obj)
        {
            Person compPerson = (Person)obj;
            return string.Compare(this.LastName, compPerson.LastName);
        }
    }
}
