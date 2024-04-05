using MAS.Person;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAS.MedicineTest
{
    public class TestGroup
    {
        private Researcher _researcher;
        public Researcher ResearcherResponsible
        {
            get { return _researcher; } 
            set {
                if ( _researcher == null)
                {
                    _researcher = value;
                } else if (value != null && value != _researcher)
                {
                    _researcher.RemoveGroup(this);
                    _researcher = value;
                    _researcher.AddGroup(this);
                }
            } 
        }

        public ICollection<ObservedParticipant> ObservedParticipants = new HashSet<ObservedParticipant>();

    }
}
