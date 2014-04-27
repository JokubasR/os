using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace os.RealMachine
{
    class PageTableTranslator
    {
        public void setBlock(int number, char[][] data)
        {
            int from = number * 16;
            int to = from + 16;
            int i = 0;
            for (int j = from; j <= to && i < data.Length; j++)
            {
                os.RealMachine.Memory.memoryTable[j] = data[i];
                i++;
            }
        }

        public static char[][] getBlock(int number){
            char[][] block = new char[16][];        
            int from = number*16;
            int to = from + 16;
            block = os.RealMachine.Memory.memoryTable.Skip(from).Take(from - to).ToArray();
            return block;
        }

        public static char[] getWord(int block_nr, int word_nr)
        {
            return os.RealMachine.Memory.memoryTable[block_nr * 16 + word_nr];
        }

        public static void setWord(int block_nr, int word_nr, char[] data)
        {
            os.RealMachine.Memory.memoryTable[block_nr * 16 + word_nr] = data;
        }


    }
}
