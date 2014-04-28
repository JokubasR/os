using os.RealMachine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace os.Type
{
    abstract class AbstractMemory
    {
        public const UInt16 MEMORY_SIZE_BLOCK = 256;
        public const byte MEMORY_SIZE_WORD = 16;
        public const byte SIZE_WORD = 4;
        protected const string EMPTY_WORD_SYMBOL = "$$$$";

        protected MemoryCell[] _memory;

        protected Mode MODE;

        /// <summary>
        /// Empty constructor. Doesn't do a shit.
        /// </summary>
        public AbstractMemory() 
        { }

        /// <summary>
        /// Initializes memory
        /// </summary>
        /// <param name="mode"></param>
        public AbstractMemory(Mode mode)
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

        public void SetBlock(List<MemoryCell> data, Address address)
        {
            for (byte key = 0; key < MEMORY_SIZE_WORD; key++)
            {
                if (data.Count > key && !String.IsNullOrEmpty(data[key].Value))
                {
                    Set(data[key], new Address(address.Block, key));
                }
                else
                {
                    Set(new MemoryCell()
                    {
                        Value = EMPTY_WORD_SYMBOL,
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

        public void DebugMemory()
        {
            Console.ForegroundColor = ConsoleColor.Black;
            byte word = 0;
            foreach (var chunk in _memory)
            {
                Console.BackgroundColor = chunk.Reserved == true
                    ? ConsoleColor.Red 
                    : ConsoleColor.Green;
                Console.Write(chunk.Value);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write(' ');
                if (++word >= MEMORY_SIZE_WORD)
                {
                    Console.WriteLine();
                    word = 0;
                }
            }
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
