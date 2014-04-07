using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace os.VirtualMachine
{
    class VirtualMachine
    {
        public VirtualCPU CPU { get; set; }

        public VirtualMemory Memory { get; set; }

        protected Interpreter Interpreter { get; set; }

        public VirtualMachine()
        {
            CPU = new VirtualCPU();
            Memory = new VirtualMemory();
            Interpreter = new Interpreter();
        }
    }
}
