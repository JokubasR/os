﻿using os.RealMachine;
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
            VM.VirtualMachine virtualMachine = new VM.VirtualMachine();

            Console.WriteLine("Hello, please, enter something:");
            string program = Console.ReadLine();            

            StreamReader streamReader = new StreamReader(@"../../" + program);
            List<MemoryCell> memoryCells;
            byte block = 0;
            string word = null;
            while (!streamReader.EndOfStream)
            {
                string currentBlock = streamReader.ReadLine();
                memoryCells = new List<MemoryCell>();
                int last = currentBlock.Length;
                int iterations = 1;
                foreach (char chunk in currentBlock.ToCharArray())
                    {

                        word += chunk.ToString();
                        if ((word.Length == VM.VirtualMemory.SIZE_WORD) || (iterations == last))
                        {
                            memoryCells.Add(new MemoryCell()
                            {
                                Value = word,
                                Reserved = true
                            });
                            word = null;
                        }
                        iterations++;
                    }

                virtualMachine.Memory.SetBlock(memoryCells, new Address(block++, 0));
            }

            Console.WriteLine("Program written to VM memory successfully");

            virtualMachine.Memory.DebugMemory();

            Console.ReadLine();
        }
    }
}
