﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadBook.CsharpBasic.Chapter02.Examples
{
    internal class Ex007
    {
        public void Run()
        {
            int 국어 = 100;
            int 영어 = 100;
            int 수학 = 98;
            int 체육 = 97;
            int sum = 0;
            sum = 국어 + 영어 + 수학 + 체육;
            Console.WriteLine("합계 : {0}, 평균 : {1}", sum, sum/4);
        }
    }
}
