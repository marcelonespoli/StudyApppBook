using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CommandEndActiveObject.ActiveObject
{
    public class ActiveObjectEngine
    {
        private ArrayList commands = new ArrayList();

        public void AddCommand(Command command)
        {
            commands.Add(command);
        }

        public void Run()
        {
            while (commands.Count > 0)
            {
                var command = (Command)commands[0];
                commands.RemoveAt(0);
                command.Execute();
            }
        }
    }
}
