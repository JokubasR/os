using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace os.RealMachine
{
    enum Mode
    {
        USER,
        SUPERVISOR
    }  

    class CPU
    {
        private int AX { get; set; }
        private int BX { get; set; }

        /// <summary>
        /// Program counter
        /// </summary>
        private int PC { get; set; }

        /// <summary>
        /// compare result
        /// </summary>
        private byte SF { get; set; }

        /// <summary>
        /// programic interupt
        /// </summary>
        private bool PI  { get; set; }

        /// <summary>
        /// supervisor interupt
        /// </summary>
        private bool SI  { get; set; }

        /// <summary>
        /// input / output interupt
        /// </summary>
        private bool IOI  { get; set; }

        /// <summary>
        /// timer interupt
        /// </summary>
        private bool TI  { get; set; }

        /// <summary>
        /// instruction count
        /// </summary>
        private int IC { get; set; }

        /// <summary>
        /// is user mode
        /// </summary>
        private Mode MODE { get; set; }

        /* channel state [i] */
         private bool CHST1 { get; set; } 
         private bool CHST2 { get; set; }
         private bool CHST3 { get; set; }

        /// <summary>
         /// code segment start
        /// </summary>
        private int CS { get; set; }     

        /// <summary>
        /// data segment start
        /// </summary>
        private int DS { get; set; }

        /// <summary>
        /// get data (for real?)
        /// </summary>
        private int GD { get; set; }

        /// <summary>
        /// put data (for real?)
        /// </summary>
        private int SD { get; set; }

        public CPU()
        {
            
        }

        public void DecodeStream(string stream)
        {

        }
    }
}
