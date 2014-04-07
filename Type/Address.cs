using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using os.Exception;

namespace os.Type
{
    class Address
    {
        const byte NUMERAL_SYSTEM = 16;
        const byte ADDRESS_LENGTH = 4;
        private byte block;

        private byte word;

        public Address(string address)
            : this(int.Parse(address))
        {            
        }

        /// <summary>
        /// Initializes address
        /// </summary>
        /// <param name="address"></param>
        public Address(int address)
        {
            if (address.ToString().Length == ADDRESS_LENGTH)
            {
                block = (byte)(address / (NUMERAL_SYSTEM ^ 2));
                word = (byte)(address % (NUMERAL_SYSTEM^2));
            }
            else
            {
                throw new BadAddressException(String.Format("Specified address - {1} is {0}.", address.ToString().Length < ADDRESS_LENGTH ? "to short" : "to long", address));
            }
        }

        /// <summary>
        /// Initializes address
        /// </summary>
        /// <param name="_block"></param>
        /// <param name="_word"></param>
        public Address(byte _block, byte _word)
        {
            if (_block < (Math.Pow(NUMERAL_SYSTEM, 2))
                && _word < (Math.Pow(NUMERAL_SYSTEM, 2)))
            {
                block = _block;
                word = _word;
            }
            else
            {
                throw new BadAddressException(String.Format("Block {0} or word {1} address is bad.", _block, _word));
            }
        }

        /// <summary>
        /// Full address get from block and word addresses
        /// </summary>
        public int FullAddress
        {
            get { return block * NUMERAL_SYSTEM + word; }
        }

        /// <summary>
        /// Returns block number
        /// </summary>
        public byte Block
        {
            get { return block; }
        }

        /// <summary>
        /// Returns block start address
        /// </summary>
        public int BlockStartAddress
        {
            get { return block * ((int)Math.Pow(NUMERAL_SYSTEM, 2)); }
        }

        /// <summary>
        /// Returns word number
        /// </summary>
        public byte Word
        {
            get { return word; }
        }

    }
}
