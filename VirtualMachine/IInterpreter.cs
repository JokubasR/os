using os.Type;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace os.VirtualMachine
{
    interface IInterpreter
    {
        void ADD(Address address);
        void SUB(Address address);
        void MUL(Address address);
        void DIV(Address address);
        void NEG(Address address);

        void AND(Address address);
        void OR(Address address);
        void NOT(Address address);

        void COMP(Address address);

        void LW(Address address);
        void PW(Address address);

        void HALT();

        void LB(Address address);
        void DB(Address address);
        void RD(Address address);

    }
}
