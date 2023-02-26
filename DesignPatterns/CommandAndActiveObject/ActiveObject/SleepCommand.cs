using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CommandEndActiveObject.ActiveObject
{
    public class SleepCommand : Command
    {
        private Command wakeupCommand = null;
        private ActiveObjectEngine engine = null;
        private long sleepTime = 0;
        private DateTime startTime;
        private bool started = false;

        public SleepCommand(long miliseconds, ActiveObjectEngine engine, Command wakeupCommand)
        {
            sleepTime = miliseconds;
            this.engine = engine;
            this.wakeupCommand = wakeupCommand;
        }

        public void Execute()
        {
            var currentTime = DateTime.Now;
            if (!started)
            {
                started = true;
                startTime = currentTime;
                engine.AddCommand(this);
            }
            else
            {
                var elapsedTime = currentTime - startTime;
                if (elapsedTime.TotalMilliseconds < sleepTime)
                {
                    engine.AddCommand(this);
                }
                else
                {
                    engine.AddCommand(wakeupCommand);
                }
            }
        }
    }
}
