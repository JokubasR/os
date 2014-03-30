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

        /* program counter */
        private int PC { get; set; }

        /* compare result */
        private byte SF { get; set; }

        /* programic interupt */
        private bool PI  { get; set; }

        /* supervisor interupt */
        private bool SI  { get; set; }

        /* input / output interupt */
        private bool IOI  { get; set; }

        /* timer interupt */
        private bool TI  { get; set; }

        /* instruction count */
        private int IC { get; set; }

        /* is user mode */
        private Mode MODE { get; set; }


        /* channel state [i] */
         private bool CHST1 { get; set; } 
         private bool CHST2 { get; set; }
         private bool CHST3 { get; set; }

        /* code segment start */
        private int CS { get; set; }     

        /* data segment start */
        private int DS { get; set; }

        /* get data */
        private int GD { get; set; }

        /* put data */
        private int SD { get; set; }


    }
}
