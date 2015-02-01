using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace AsynchronousTimer
{
    class AsyncTimer
    {
        private Action method;
        private int ticks;
        private int t;
        
        public AsyncTimer(Action act, int ticks, int t)
        {
            this.method = act;
            this.Ticks = ticks;
            this.Interval = t;
        }

        private int Ticks
        {
            set
            {
                if (value < 1)
                    throw new ArgumentOutOfRangeException("The number of repeats must be > 0! ");
                this.ticks = value;
            }
        }

        private int Interval
        {
            set
            {
                if (value < 1)
                    throw new ArgumentOutOfRangeException("The interval in miliseconds must be > 0! ");
                this.t = value;
            }
        }

        private void Akshon()
        {
            int count = 0;
            while (count < this.ticks)
            {
                Thread.Sleep(this.t);

                if (method != null)
                {
                    method();
                }

                count++;
            }
        }

        public void Start()
        {
            Thread thread = new Thread(this.Akshon);
            thread.Start();
        }

    }
}
