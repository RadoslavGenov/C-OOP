using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class GSMTest
    {
        private GSM[] test = new GSM[5];
        public void DisplayInfo(GSM[] test)
        {
            foreach (var phone in test)
            {
                Console.WriteLine(test.ToString());
            }
        }
    }
}
