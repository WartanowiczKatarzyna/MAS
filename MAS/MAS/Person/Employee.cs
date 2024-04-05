using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAS.Person
{
    public class Employee : Person
    {
        public Employee(string name, string surname, string phoneNumber, string email, Address address) : base(name, surname, phoneNumber, email, address)
        {
        }
    }
}
