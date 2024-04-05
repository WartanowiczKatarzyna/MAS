using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MAS.Person
{
    public class Address
    {
        string Country { get; set; }
        string City { get; set; }
        string PostalCode { get; set; }
        
        // atrybut opcjonalny
        string? Street { get; set; }
        
        // atrybut opcjonalny
        int? StreetNumber { get; set; }
        
        string HouseNumber { get; set; }

        // atrybut pochodny
        [JsonIgnore]
        public string PostalAddress { 
            get {
                if (Street == null)
                {
                    return $"{City} {HouseNumber}\n {PostalCode} {City.ToUpperInvariant()}\n {Country.ToUpperInvariant()}";
                }                    
                return $"{Street} {StreetNumber} {HouseNumber}\n {PostalCode} {City.ToUpperInvariant()}\n {Country.ToUpperInvariant()}";
            }
        }

        public Address(string country, string city, string postalCode, string? street, int? streetNumber, string houseNumber)
        {
            Country = country;
            City = city;
            PostalCode = postalCode;
            Street = street;
            StreetNumber = streetNumber;
            HouseNumber = houseNumber;
        }
    }
}
