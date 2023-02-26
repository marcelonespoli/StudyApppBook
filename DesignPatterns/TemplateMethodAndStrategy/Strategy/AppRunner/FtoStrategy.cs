using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.TemplateMethodAndStrategy.Strategy.AppRunner
{
    public class FtoStrategy : Application
    {
        private TextReader input;
        private TextWriter output;
        private bool isDone = false;

        public void Init()
        {
            input = Console.In;
            output = Console.Out;
        }

        public void Idle()
        {
            var fahrString = input.ReadLine();
            if (fahrString == null || fahrString.Length == 0)
            {
                isDone = true;
            }
            else
            {
                var fahr = double.Parse(fahrString);
                var celcius = 5.0 / 9.0 * (fahr - 32);
                output.WriteLine("F={0}, C={1}", fahr, celcius);
            }
        }

        public void CleanUp()
        {
            output.WriteLine("ftoc exit");
        }

        public bool Done()
        {
            return isDone;
        }

    }
}
