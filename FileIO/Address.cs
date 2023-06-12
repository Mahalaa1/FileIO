using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIO
{
    internal class Address
    {
        public string? Number { get; init; } = String.Empty;

        public string? Street { get; init; } = String.Empty;

        public string? City { get; init; } = String.Empty;

        public string? State { get; init; } = String.Empty;

        public string? ZipCode { get; init; } = String.Empty;

        public Address()
        {

        }

        public Address(string? number, string? street, string? city, string? state, string? zipCode)
        {
            Number = number;
            Street = street;
            City = city;
            State = state;
            ZipCode = zipCode;
        }

        public override string ToString()
        {
            return $"{Number} {Street} {City}, {State} {ZipCode}";
        }
    }
}
