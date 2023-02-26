using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CommandEndActiveObject.Commands
{
    public interface Transaction
    {
        void Validate();
        void Execute();
    }
}
