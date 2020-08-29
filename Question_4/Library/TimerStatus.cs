using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Question_4.Library
{
    public class TimerStatus
    {

        private int invokeMs;
        private int maxMs;

        public TimerStatus(int ms)
        {
            invokeMs = 0;
            maxMs = ms;
        }
        public void Check(Object Info)
        {
            AutoResetEvent autoEvent = (AutoResetEvent)Info;
            Console.WriteLine("{0} Status {1,2}.",
                DateTime.Now.ToString("h:mm:ss.fff"),
                (++invokeMs).ToString() + "/" + maxMs);

            if (invokeMs == maxMs)
            {
                // Reset the counter and signal the waiting thread.
                invokeMs = 0;
                autoEvent.Set();
            }
        }
    }
}

