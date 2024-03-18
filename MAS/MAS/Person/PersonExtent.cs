using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAS.Person
{
    // ekstensja klasy Person
    public class PersonExtent
    {
        // atrybut powtarzalny, atrybut klasowy klasy Person
        private ICollection<Person> _persons = new List<Person>();

        public void AddPerson(Person person)
        {
            _persons.Add(person);
        }
        public void RemovePerson(Person person)
        {
            _persons.Remove(person);
        }
        
        // metoda klasow klasy Person
        public void ShowExtent()
        {
            Console.WriteLine($"Extent of the class Person:");
            foreach (Person person in _persons)
            {
                Console.WriteLine(person.ToString());
            }
        }
    }
}
