using DesignPatterns.CommandEndActiveObject;
using DesignPatterns.CommandEndActiveObject.ActiveObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    public class ActiveObjectTests
    {
        [Fact]
        public void Test1()
        {
            var wakeUp = new WakeupCommand();
            var engine = new ActiveObjectEngine();
            var sleepCommand = new SleepCommand(1000, engine, wakeUp);
            engine.AddCommand(sleepCommand);
            var start = DateTime.Now;
            engine.Run();
            var stop = DateTime.Now;
            var sleepTime = (stop - start).TotalMilliseconds;
            Assert.True(sleepTime >= 1000, $"sleepTime {sleepTime} expected > 1000");
            Assert.True(sleepTime <= 1100, $"sleepTime {sleepTime} expected < 1100");
            Assert.Equal("Worked processed!", wakeUp.Message);
        }
    }
}
