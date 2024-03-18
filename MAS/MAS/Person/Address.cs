using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAS.Person
{
    public class Address
    {
        public string Country { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        
        // atrybut opcjonalny
        public string? Street { get; set; }
        
        // atrybut opcjonalny
        public string? StreetNumber { get; set; }
        
        public int HouseNumber { get; set; } 
        
        // atrybut pochodny
        public string PostalAddress { 
            get {
                if (Street == null)
                {
                    return $"{City} {HouseNumber}\n {PostalCode} {City.ToUpperInvariant()}\n {Country.ToUpperInvariant()}";
                }                    
                return $"{Street} {StreetNumber} {HouseNumber}\n {PostalCode} {City.ToUpperInvariant()}\n {Country.ToUpperInvariant()}";
            }
        }
    }
}
