﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    internal class HeadTail
    {


        public void Swaping(int num1, int num2)
        {
            int temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine("After Swapping two numbers are");
            Console.WriteLine("First Number : " + num1);
            Console.WriteLine("Second Number : " + num2);
        }
    }
}

