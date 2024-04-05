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

            /*
            personExtent1.AddPerson(person1);
            Console.WriteLine("before writing to persons \n");
            personExtent1.ShowExtent();
            personExtent1.WriteToJsonFile();

            personExtent1 = PersonExtent.ReadFromJsonFile("personsRead");
            Console.WriteLine("reading from personsRead \n");
            personExtent1.ShowExtent();
            personExtent1 = PersonExtent.ReadFromJsonFile();
            Console.WriteLine("reading from persons \n");
            personExtent1.ShowExtent();
            */

            // testing TestGroup - Researcher association
            TestGroup testGroup = new TestGroup();
            Researcher researcher1 = new Researcher(person1);
            Researcher researcher2 = new Researcher(person1);

            researcher1.AddGroup(testGroup);            
            researcher2.AddGroup(testGroup);
            testGroup.ResearcherResponsible = researcher1;

            // testing TestGroup - (ObservedParticipant) - Participant association
            Participant participant1 = new Participant(person1);
            ObservedParticipant observedParticipant = new ObservedParticipant(testGroup, participant1, ObservedParticipant.Effectiveness.CurrentlyTesting);

            // testing Researcher - Test association
            Test test = new Test("Blabax");
            researcher2.AddTest(test);

            // testing Test - TestPhase association
            TestPhase testPhase = TestPhase.CreateTestPhase(test);
            Test test2 = new Test("Vrongax");
            // checking if TestPhase exclusivity is implemented correctly
            //test2.AddPhase(testPhase);
        }
    }
}