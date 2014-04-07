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
        public Memory() 
            : base()
        {
            _memory = new MemoryCell[MEMORY_SIZE_BLOCK * MEMORY_SIZE_WORD];
        }

        
    }
}
