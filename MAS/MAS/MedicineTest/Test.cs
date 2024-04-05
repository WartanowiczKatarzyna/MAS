using MAS.Person;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAS.MedicineTest
{
    public class Test
    {
        public Medicine Medicine { get; set; }
        public Researcher? Overseer { get; set; }

        private ICollection<TestPhase> _phaseList = new List<TestPhase>();
        private static ICollection<TestPhase> _allPhases = new HashSet<TestPhase>();

        public Test(Medicine medicine)
        {
            Medicine = medicine;
        }

        public Test(string medicineName)
        {
            Medicine = new Medicine(medicineName);
        }

        public void AddPhase(TestPhase phase)
        {
            if(!_phaseList.Contains(phase))
            {
                if(_allPhases.Contains(phase))
                {
                    throw new Exception("This phase belongs to other test!");
                }
                _phaseList.Add(phase);
                _allPhases.Add(phase);
            }
        }
        public void RemovePhase(TestPhase phase)
        {
            _phaseList.Remove(phase);
            _allPhases.Remove(phase);
        }
    }
}
