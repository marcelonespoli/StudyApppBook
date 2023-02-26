using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.TemplateMethodAndStrategy.TemplateMethod.AppRunner
{
    public class FtoRaw
    {
        public void Execute()
        {
            var done = false;
            while (!done)
            {
                var fahrString = Console.In.ReadLine();
                if (fahrString == null || fahrString.Length == 0)
                {
                    done = true;
                }
                else
                {
                    var fahr = double.Parse(fahrString);
                    var celcius = 5.0 / 9.0 * (fahr - 32);
                    Console.Out.WriteLine($"F = {fahr}, C = {celcius}");
                }
            }
            Console.Out.WriteLine("ftoc exit");
        }
    }
}
