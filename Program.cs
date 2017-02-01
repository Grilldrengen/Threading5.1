using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace Threading5
{
    public class Program
    {
        static Counters c;

        static object locker = new object();

        static void ThreadMain1()
        {
            while (true)
            {
                Monitor.Enter(locker);
                c.addtwo();
                Thread.Sleep(1000);
                Monitor.Pulse(locker);
                Monitor.Wait(locker);
            }
        }

        static void ThreadMain2()
        {
            while (true)
            {
                Monitor.Enter(locker);
                c.subtractone();
                Monitor.Pulse(locker);
                Monitor.Wait(locker);
            }
        }        

        static void Main(string[] args)
        {
            c = new Counters();

            Thread tid1 = new Thread(new ThreadStart(ThreadMain1));
            Thread tid2 = new Thread(new ThreadStart(ThreadMain2));

            tid1.Start();
            tid2.Start();
        }
    }
}
