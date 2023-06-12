using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIO
{
    internal class Phone
    {
        public string? CountryCode { get; init; } = String.Empty;

        public string? AreaCode { get; init; } = String.Empty;

        public string? ExchangeCode { get; init; } = String.Empty;

        public string? LineNumber { get; init; } = String.Empty;

        public string? FullNumber { get; init; } = String.Empty;

        public Phone()
        {

        }

        public Phone(string? countryCode, string? areaCode, string? exchangeCode, string? lineNumber, string? fullNumber)
        {
            CountryCode = countryCode;
            AreaCode = areaCode;
            ExchangeCode = exchangeCode;
            LineNumber = lineNumber;
            FullNumber = fullNumber;
        }
    }
}
