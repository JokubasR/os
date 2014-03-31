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
        /// <summary>
        /// Memory cell value
        /// </summary>
        public string Value 
        {
            get { return Value;}
            set { this.Value = value.Length < Memory.SIZE_WORD ? value : value.Remove(4); } 
        }

        /// <summary>
        /// Determines if this cell is already reserved
        /// </summary>
        public bool Reserved { get; set; }
    }
}
