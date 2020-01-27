using System;
using System.Timers;

namespace Learncs3
{
    class Program
    {
        static void Main(string[] args)
        {
            Timer time = new Timer(2000);
            time.Elapsed += Time_Elapsed;

            time.Start();
            Console.ReadLine();
        }

        private static void Time_Elapsed(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine(e.SignalTime);
        }
    }
}
