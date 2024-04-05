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
        
        public Researcher(string name, string surname, string phoneNumber, string email, Address address) : base(name, surname, phoneNumber, email, address)
        {
        }

        public void addGroup(TestGroup group)
        {
            
            if (!_groups.Contains(group))
            {
                _groups.Add(group);
                group.researcherResponsible = this;
            }
        }

        internal void removeGroup(TestGroup group)
        {
            _groups.Remove(group);
        }
    }
}
