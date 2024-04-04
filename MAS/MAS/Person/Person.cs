using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAS.Person
{
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        // atrybut złożony
        public Address Address { get; set; }

        public Person(string name, string surname, string phoneNumber, string email, Address address)
        {
            Name = name;
            Surname = surname;
            PhoneNumber = phoneNumber;
            Email = email;
            Address = address;
        }

        public override string ToString() 
        { 
            return $"\t {Name} {Surname} \n phone num.: {PhoneNumber} \n email: {Email} \n address: \n {Address.PostalAddress}"; 
        }
    }
}
