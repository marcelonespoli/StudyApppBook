using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DesignPatterns.CommandEndActiveObject.Commands
{
    public class AddEmployeeTransaction : Transaction
    {
        private string name;
        private int id;

        private readonly PayClassification _payClassification;

        public AddEmployeeTransaction(PayClassification payClassification, string name, int id)
        {
            _payClassification = payClassification;
            this.name = name;
            this.id = id;
        }

        public void Validate()
        {
            if (id == 0 || string.IsNullOrEmpty(name))
            {
                throw new Exception("Name or Id invalid");
            }
        }


        public void Execute()
        {
            _payClassification.CalculePay();
        }

    }
}
