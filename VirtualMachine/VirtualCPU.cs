using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace os.VirtualMachine
{
    class VirtualCPU
    {
        /// <summary>
        /// For basic usage
        /// </summary>
        private int R { get; set; }

        /// <summary>
        /// Instruction count
        /// </summary>
        private int IC { get; set; }

        /// <summary>
        /// Compare
        /// </summary>
        private int C { get; set; }
    }
}
