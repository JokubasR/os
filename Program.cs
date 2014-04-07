using os.RealMachine;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VM = os.VirtualMachine;

namespace os
{
    class Program
    {
        static void Main(string[] args)
        {
            CPU cpu = new CPU();
            VM.VirtualMachine virtualMachine = new VM.VirtualMachine();

            Console.WriteLine("Hello, my darling. Please, enter something:");
            string program = Console.ReadLine();
            Console.WriteLine("Oh you naughty boy, oh you!");

            /*
             * Nu vo, dabar reik kazkaip nuskaityt tipo sita faila. Sukelt ji VM atminti.
             */

            StreamReader streamReader = new StreamReader(program);
            string fileContent = streamReader.ReadToEnd();


        }
    }
}
