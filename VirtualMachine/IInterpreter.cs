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
        public void ADD(Address address);
        public void SUB(Address address);
        public void MUL(Address address);
        public void DIV(Address address);
        public void NEG(Address address);

        public void AND(Address address);
        public void OR(Address address);
        public void NOT(Address address);

        public void COMP(Address address);

        public void LW(Address address);
        public void PW(Address address);

        public void HALT();

        public void LB(Address address);
        public void DB(Address address);
        public void RD(Address address);

    }
}
