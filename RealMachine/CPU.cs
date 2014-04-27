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

    public static class CPU
    {
        private static int AX { get; set; }
        private static int BX { get; set; }

        /// <summary>
        /// Program counter
        /// </summary>
        private static int PC { get; set; }

        /// <summary>
        /// compare result
        /// </summary>
        private static byte SF { get; set; }

        /// <summary>
        /// programic interupt
        /// </summary>
        private static bool PI  { get; set; }

        /// <summary>
        /// supervisor interupt
        /// </summary>
        private static bool SI  { get; set; }

        /// <summary>
        /// input / output interupt
        /// </summary>
        private static bool IOI  { get; set; }

        /// <summary>
        /// timer interupt
        /// </summary>
        private static bool TI  { get; set; }

        /// <summary>
        /// instruction count
        /// </summary>
        private static int IC { get; set; }

        /// <summary>
        /// is user mode
        /// </summary>
        private static Mode MODE { get; set; }

        /* channel state [i] */
         private static bool CHST1 { get; set; } 
         private static bool CHST2 { get; set; }
         private static bool CHST3 { get; set; }

        /// <summary>
         /// code segment start
        /// </summary>
        private static int CS { get; set; }     

        /// <summary>
        /// data segment start
        /// </summary>
        private static int DS { get; set; }

        /// <summary>
        /// get data (for real?)
        /// </summary>
        private static int GD { get; set; }

        /// <summary>
        /// put data (for real?)
        /// </summary>
        private static int SD { get; set; }

        static CPU()
        {
            
        }

        public static void DecodeStream(string stream)
        {

        }
    }
}
