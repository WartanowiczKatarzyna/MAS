using MAS.Person;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAS.MedicineTest
{
    public class ObservedParticipant
    {
        public enum Effectiveness
        {
            Effective,
            Ineffective,
            CurrentlyTesting

        }

        TestGroup TestGroup {  get; set; }
        Participant Participant { get; set; }
        Effectiveness MedicineEffectiveness { get; set; }

        public ObservedParticipant(TestGroup testGroup, Participant participant, Effectiveness medicineEffectiveness)
        {
            TestGroup = testGroup;
            TestGroup.ObservedParticipants.Add(this);

            Participant = participant;
            Participant.ObservedParticipants.Add(this);

            MedicineEffectiveness = medicineEffectiveness;
        }
    }
}
