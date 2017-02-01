using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Threading5
{
    public class Counters
    {
        public int Counter = 0;

        public void addtwo()
        {
            Counter += 2;
            Console.WriteLine("--> " + Counter);
        }

        public void subtractone()
        {
            Counter -= 1;
            Console.WriteLine(Counter);
        }
    }
}
