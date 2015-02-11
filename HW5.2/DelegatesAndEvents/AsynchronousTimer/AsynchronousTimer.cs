namespace AsynchronousTimer
{
    using System;
    using System.Threading;
    class AsynchronousTimer
    {
        private int ticks;
        private int timeToWait;//in milliseconds

        public AsynchronousTimer(Action action, int ticks, int time)
        {
            this.Action = action;
            this.Ticks = ticks;
            this.TimeToWait = time;
        }

        public int Ticks
        {
            get
            {
                return this.ticks;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Ticks cannot be negative");
                }

                this.ticks = value;
            }
        }

        public int TimeToWait
        {
            get
            {
                return this.timeToWait;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Time to wait cannot be negative");
                }

                this.timeToWait = value;
            }
        }

        public Action Action { get; set; }

        public void Execute()
        {
            Thread actionThread = new Thread(() =>
                {
                    int ticks=this.Ticks;
                    while (ticks > 0)
                    {
                        Thread.Sleep(this.TimeToWait);
                        this.Action();
                        ticks--;
                    }
                });

            actionThread.Start();
        }
    }
}
