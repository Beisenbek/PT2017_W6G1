using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Timer
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t = new Thread(new ThreadStart(DoIt));
            t.Start();
            Thread t2 = new Thread(new ThreadStart(DoIt));
            t2.Start();
        }

        static void DoIt()
        {
            while (true)
            {
                Console.WriteLine("ok!");
                Thread.Sleep(1000);
            }
        }
    }
}
