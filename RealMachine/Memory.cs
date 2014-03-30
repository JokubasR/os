using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace os.RealMachine
{
    class Memory
    {
        const UInt16 MEMORY_SIZE_BLOCK  = 256;
        const byte   MEMORY_SIZE_WORD   = 16;
        const byte   SIZE_WORD          = 4;

        private Mode MODE;

        //private char[] _memory = new string[256, 16];

        public Memory(Mode mode)
        {
            this.MODE = mode;
        }

        public void PutData(object data)
        {
            if (data is string)
            {

            }
        }

        public object GetData()
        {
            return new Object();
        }
    }
}
