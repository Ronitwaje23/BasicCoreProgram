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
            Console.WriteLine("Enter charactor");
            char alphabet = Convert.ToChar(Console.ReadLine());


            head.vowel_consonant(alphabet);
            Console.ReadLine();

        }
    }
}
