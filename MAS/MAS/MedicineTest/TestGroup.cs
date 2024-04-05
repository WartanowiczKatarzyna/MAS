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
        public Researcher researcherResponsible { 
            get { return _researcher; } 
            set {
                if (value != null && value != _researcher)
                {
                    _researcher.removeGroup(this);
                    _researcher = value;
                    _researcher.addGroup(this);
                }
            } 
        }


    }
}
