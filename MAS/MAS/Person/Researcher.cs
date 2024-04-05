using MAS.MedicineTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAS.Person
{
    public class Researcher : Employee
    {
        private ICollection<TestGroup> _groups = new HashSet<TestGroup>();
        private IDictionary<string, Test> _tests = new Dictionary<string, Test>();
        
        public Researcher(string name, string surname, string phoneNumber, string email, Address address) : base(name, surname, phoneNumber, email, address) { }

        public Researcher(Person person) : base(person) { }  

        public void AddGroup(TestGroup group)
        {
            
            if (!_groups.Contains(group))
            {
                _groups.Add(group);
                group.ResearcherResponsible = this;
            }
        }

        // called only by researcherResponsible setter in TestGroup when changing researcherResponsible to another existing researcher (association 1-to-many)
        internal void RemoveGroup(TestGroup group)
        {
            _groups.Remove(group);
        }

        public void AddTest(Test test)
        {
            if (!_tests.ContainsKey(test.Medicine.Name))
            {
                _tests.Add(test.Medicine.Name, test);
                test.Overseer = this;
            }
        }

        public void RemoveTest(Test test) 
        {
            _tests.Remove(test.Medicine.Name);
            test.Overseer = null;
        }
        public Test FindTest(String medicineName)
        {
            if(!_tests.ContainsKey(medicineName))
            {
                throw new Exception("This researcher doesn't oversee test for this medicine!");
            } 
            return _tests[medicineName];
        }
    }
}
