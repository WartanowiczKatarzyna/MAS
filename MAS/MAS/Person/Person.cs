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
        // atrybut złożony
        public Address Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }
}
