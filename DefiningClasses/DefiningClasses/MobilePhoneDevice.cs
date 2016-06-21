using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class MobileDevice
    {
        static void Main(string[] args)
        {
            GSM gsm = new GSM("rado", "genov");
            Console.WriteLine(gsm.ToString());
        }
    }
}
