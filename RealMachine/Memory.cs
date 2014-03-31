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
        const byte   SIZE_WORD          = 4;
        const char EMPTY_WORD_SYMBOL    = '$';

        private Mode MODE;

        private string[] _memory = new string[MEMORY_SIZE_BLOCK * MEMORY_SIZE_WORD];

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
        public void Set(object data)
        {
            if (isDataValid(data))
            {
                foreach (var word in _memory)
                {
                    if (String.IsNullOrEmpty(word))
                    {
                        Set(data, new Address(word));
                    }
                }
            }
        }

        
        /// <summary>
        /// Puts one word into given address
        /// </summary>
        /// <param name="data">data</param>
        /// <param name="address">address</param>
        public void Set(object data, Address address)
        {
            if (isDataValid(data))
            {
                _memory[address.FullAddress] = data.ToString();
            }
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

        public void SetBlock(object[] data, Address address)
        {
            for (byte key = 0; key < MEMORY_SIZE_WORD; key++)
            {
                if (isDataValid(data[key], throwException: false))
                {
                    Set(data, new Address(address.Block, key));
                }
                else
                {
                    Set(EMPTY_WORD_SYMBOL, new Address(address.Block, key));
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

        /// <summary>
        /// Checks if given data is valid - data size is no more then SIZE_WORD
        /// </summary>
        /// <param name="data"></param>
        /// <param name="throwException"></param>
        /// <returns></returns>
        private bool isDataValid(object data, bool throwException = false)
        {
            try
            {
                if (data.ToString().Length > SIZE_WORD)
                {
                    return true;
                }
                else if (throwException)
                {
                    throw new NotValidDataException(string.Format("Given data length is to long. It should be {0} bytes.", SIZE_WORD));
                }
            }
            catch (System.Exception)
            {
                throw;
            }

            return false;
        }
    }
}
