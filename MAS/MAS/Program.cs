using MAS.MedicineTest;
using MAS.Person;

namespace MAS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonExtent personExtent1 = new PersonExtent();

            Address address1 = new Address("Polska", "Warszawa", "02-110", "Grójecka", 110, "25a");
            Person.Person person1 = new Person.Person("Anna", "Kowal", "789687586", "akowal@bla.pl", address1);

            personExtent1.AddPerson(person1);
            Console.WriteLine("before writing to persons \n");
            personExtent1.ShowExtent();
            personExtent1.WriteToJsonFile();

            personExtent1 = PersonExtent.ReadFromJsonFile("personsRead");
            Console.WriteLine("reading from personsRead \n");
            personExtent1.ShowExtent();
            personExtent1 = Person.PersonExtent.ReadFromJsonFile();
            Console.WriteLine("reading from persons \n");
            personExtent1.ShowExtent();

            TestGroup
        }
    }
}