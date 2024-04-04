namespace MAS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person.PersonExtent personExtent1 = new Person.PersonExtent();

            Person.Address address1 = new Person.Address("Polska", "Warszawa", "02-110", "Grójecka", 110, "25a");
            Person.Person person1 = new Person.Person("Anna", "Kowal", "789687586", "akowal@bla.pl", address1);

            personExtent1.AddPerson(person1);
            Console.WriteLine("before writing to persons \n");
            personExtent1.ShowExtent();
            personExtent1.WriteToJsonFile();

            personExtent1 = Person.PersonExtent.ReadFromJsonFile("personsRead");
            Console.WriteLine("reading from personsRead \n");
            personExtent1.ShowExtent();
            personExtent1 = Person.PersonExtent.ReadFromJsonFile();
            Console.WriteLine("reading from persons \n");
            personExtent1.ShowExtent();
        }
    }
}