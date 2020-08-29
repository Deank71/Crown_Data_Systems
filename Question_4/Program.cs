using Question_4.Library;
using System;
using System.Threading;

namespace Question_4
{
    class Program
    {
        static void Main(string[] args)
        {
        var timerEvent = new AutoResetEvent(false);

            var timerSatus = new TimerStatus(200);

            Console.WriteLine("Start timer.\n",
                              DateTime.Now);
            var stateTimer = new Timer(timerSatus.Check,
                                       timerEvent, 2000, 10);
            timerEvent.WaitOne();
            stateTimer.Dispose();
            Console.WriteLine("\nDone.");
        }
    }
}
