using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CommandEndActiveObject.ActiveObject
{
    public class WakeupCommand : Command
    {
        public string Message { get; set; } // added this property to use it as a output on the tests

        public void Execute()
        {
            Message = "Worked processed!";
        }
    }
}
