using os.Type;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace os.VirtualMachine
{
    class VirtualMemory : AbstractMemory
    {
        public VirtualMemory()
            : base()
        {
            _memory = new MemoryCell[(int)Math.Pow(MEMORY_SIZE_WORD, 2)];
        }
    }
}
