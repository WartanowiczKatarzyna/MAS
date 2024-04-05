using MAS.MedicineTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAS.Person
{
    public class Participant : Person
    {
        public ICollection<ObservedParticipant> ObservedParticipants = new HashSet<ObservedParticipant>();
        
        public Participant(string name, string surname, string phoneNumber, string email, Address address) : base(name, surname, phoneNumber, email, address) { }

        public Participant(Person person) : base(person) { }
    }
}
