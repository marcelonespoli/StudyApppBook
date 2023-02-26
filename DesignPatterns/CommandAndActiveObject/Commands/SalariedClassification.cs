using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CommandEndActiveObject.Commands
{
    public class SalariedClassification : PayClassification
    {
        public double MonthlyPay;

        public void CalculePay()
        {
            MonthlyPay = 2500;
        }
    }
}
