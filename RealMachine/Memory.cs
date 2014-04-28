using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using os.Type;
using os.Exception;

namespace os.RealMachine
{
    class Memory : AbstractMemory
    {
        public static os.Type.MemoryCell[] memoryTable = new os.Type.MemoryCell[os.RealMachine.Memory.MEMORY_SIZE_BLOCK];

        public Memory() 
            : base()
        {
            _memory = new MemoryCell[MEMORY_SIZE_BLOCK * MEMORY_SIZE_WORD];
        }

        
    }
}
