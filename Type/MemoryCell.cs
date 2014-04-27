using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using os.RealMachine;

namespace os.Type
{
    struct MemoryCell
    {
        private string value;

        /// <summary>
        /// Memory cell value
        /// </summary>
        public string Value 
        {
            get { return value; }
            set
            {
                if (value.Length <= AbstractMemory.SIZE_WORD)
                    this.value = value;
                else
                    this.value = value.Remove(4);
            } 
        }

        /// <summary>
        /// Determines if this cell is already reserved
        /// </summary>
        public bool Reserved { get; set; }
    }
}
