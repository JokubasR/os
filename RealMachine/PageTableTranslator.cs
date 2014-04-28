using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace os.RealMachine
{
    class PageTableTranslator
    {
        public void setBlock(int number, string[] data)
        {
            int from = number * 16;
            int to = from + 16;
            int i = 0;
            for (int j = from; j <= to && i < data.Length; j++)
            {
                os.RealMachine.Memory.memoryTable[j].Value = data[i];
                i++;
            }
        }

        public static os.Type.MemoryCell[] getBlock(int number){
            os.Type.MemoryCell[] blocks = new os.Type.MemoryCell[os.RealMachine.Memory.MEMORY_SIZE_BLOCK];        
            int from = number*16;
            int to = from + 16;
            blocks = os.RealMachine.Memory.memoryTable.Skip(from).Take(from - to).ToArray();
            return blocks;
        }

        public static os.Type.MemoryCell getWord(int block_nr, int word_nr)
        {
            return os.RealMachine.Memory.memoryTable[block_nr * 16 + word_nr];
        }

        public static void setWord(int block_nr, int word_nr, string data)
        {
            os.RealMachine.Memory.memoryTable[block_nr * 16 + word_nr].Value = data;
        }


    }
}
