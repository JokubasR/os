using os.RealMachine;
using os.Type;
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

            Console.WriteLine("Hello, please, enter something:");
            string program = Console.ReadLine();            

            StreamReader streamReader = new StreamReader(@"../../" + program);
            List<MemoryCell> memoryCells;
            byte block = 0;
            while (!streamReader.EndOfStream)
            {
                string currentBlock = streamReader.ReadLine();
                memoryCells = new List<MemoryCell>();
                foreach (char chunk in currentBlock.ToCharArray())
                {
                    memoryCells.Add(new MemoryCell()
                    {
                        Value = chunk.ToString(),
                        Reserved = true
                    });
                }

                virtualMachine.Memory.SetBlock(memoryCells, new Address(block++, 0));
            }

            Console.WriteLine("Program written to VM memory successfully");

            virtualMachine.Memory.DebugMemory();

            Console.ReadLine();
        }
    }
}
