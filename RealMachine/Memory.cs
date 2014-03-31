using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using os.Type;
using os.Exception;

namespace os.RealMachine
{
    class Memory
    {
        const UInt16 MEMORY_SIZE_BLOCK  = 256;
        const byte   MEMORY_SIZE_WORD   = 16;
        public const byte SIZE_WORD = 4;
        const char EMPTY_WORD_SYMBOL    = '$';

        private Mode MODE;

        private MemoryCell[] _memory = new MemoryCell[MEMORY_SIZE_BLOCK * MEMORY_SIZE_WORD];

        /// <summary>
        /// Empty constructor. Doesn't do a shit.
        /// </summary>
        public Memory()
        {

        }

        /// <summary>
        /// Initializes memory
        /// </summary>
        /// <param name="mode"></param>
        public Memory(Mode mode)
        {
            this.MODE = mode;
        }

        /// <summary>
        /// Puts one word into first free cell
        /// </summary>
        /// <param name="data">data</param>
        public void Set(MemoryCell data)
        {
            for (int i = 0; i < _memory.Length; i++)
			{
                if (String.IsNullOrEmpty(_memory[i].Value))
                {
                    Set(data, new Address(i));
                }
			}
        }

        
        /// <summary>
        /// Puts one word into given address
        /// </summary>
        /// <param name="data">data</param>
        /// <param name="address">address</param>
        public void Set(MemoryCell data, Address address)
        {
            _memory[address.FullAddress] = data;
        }

        /// <summary>
        /// Returns data from given address
        /// </summary>
        /// <param name="address">address</param>
        /// <returns>data</returns>
        public object Get(Address address)
        {
            return _memory[address.FullAddress];
        }

        public void SetBlock(MemoryCell[] data, Address address)
        {
            for (byte key = 0; key < MEMORY_SIZE_WORD; key++)
            {
                if (!String.IsNullOrEmpty(data[key].Value) && data[key].Reserved == false)
                {
                    Set(data[key], new Address(address.Block, key));
                }
                else
                {
                    Set(new MemoryCell() 
                            {   
                                Value = EMPTY_WORD_SYMBOL.ToString(), 
                                Reserved = false 
                            }, new Address(address.Block, key));
                }
            }                           
        }

        /// <summary>
        /// Gets data from block
        /// </summary>
        /// <param name="address">address</param>
        /// <returns>data</returns>
        public string GetBlock(Address address)
        {
            string data = "";
            for (byte key = 0; key < MEMORY_SIZE_WORD; key++)
            {
                data += Get(new Address(address.Block, key));
            }

            return data;
        }
    }
}
