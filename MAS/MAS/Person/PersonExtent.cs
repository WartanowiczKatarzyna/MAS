using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.Json;
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
        
        // metoda klasowa klasy Person
        public void ShowExtent()
        {
            Console.WriteLine($"Extent of the class {this.ToString()}:");
            foreach (Person person in _persons)
            {
                Console.WriteLine(person.ToString());
            }
            Console.WriteLine();
        }
        public void WriteToJsonFile()
        {
            string jsonString = JsonSerializer.Serialize(_persons);
            string projectRoot = Directory.GetCurrentDirectory();
            string fileName = Path.Combine(projectRoot, "JsonFiles", "persons.json");
            File.WriteAllText(fileName, jsonString);
        }
        public static PersonExtent ReadFromJsonFile(string file)
        {
            string projectRoot = Directory.GetCurrentDirectory();
            string fileName = Path.Combine(projectRoot, "JsonFiles", $"{file}.json");
            string jsonString = File.ReadAllText(fileName);
            PersonExtent personExtent = new PersonExtent();
            personExtent._persons = JsonSerializer.Deserialize<List<Person>>(jsonString);

            return personExtent;
        }
        // metoda klasowa klasy PersonExtent
        public static PersonExtent ReadFromJsonFile()
        {
            return ReadFromJsonFile("persons");
        }
    }
}
