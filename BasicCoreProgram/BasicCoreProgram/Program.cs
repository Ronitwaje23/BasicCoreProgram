using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to basic program");
            HeadTail head = new HeadTail();

            head.Swaping(25 ,4  );
            Console.ReadLine();

        }
    }
}
