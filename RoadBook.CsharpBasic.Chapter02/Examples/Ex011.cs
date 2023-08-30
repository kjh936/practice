﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RoadBook.CsharpBasic.Chapter02.Examples
{
    internal class Ex011
    {
        int globalValue = 20;
        public void Run()
        {
            int localValue = 10;

            Sum();
            Multiple();

            Console.WriteLine("local : {0} / global {1}", localValue, globalValue);
        }

        public void Sum()
        {
            globalValue = globalValue + 10;
        }

        public void Multiple()
        {
            globalValue = globalValue * 2;
        }
    }
}
