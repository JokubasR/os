using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace os.VirtualMachine
{
    class VirtualMachine
    {
        protected VirtualCPU virtualCPU;

        protected VirtualMemory virtualMemory;

        protected Interpreter interpreter;

        public VirtualMachine()
        {
            virtualCPU = new VirtualCPU();
            virtualMemory = new VirtualMemory();
            interpreter = new Interpreter();
        }
    }
}
