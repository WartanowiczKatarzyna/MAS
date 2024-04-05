using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAS.MedicineTest
{
    public class TestPhase
    {
        private Test _test;
        private TestPhase(Test test)
        {
            _test = test;
        }

        public static TestPhase CreateTestPhase(Test test)
        {
            if (test == null)
            {
                throw new ArgumentNullException("Test doesn't exist!");
            }

            TestPhase testPhase = new TestPhase(test);
            test.AddPhase(testPhase);
            return testPhase;
        }
    }
}
