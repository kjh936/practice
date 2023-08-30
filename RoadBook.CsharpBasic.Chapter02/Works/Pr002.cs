using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadBook.CsharpBasic.Chapter02.Works
{
    internal class Pr002
    {
        public void Run()
        {
            Console.WriteLine("숫자를 차례대로 입력하세요.");
            int firstValue = Convert.ToInt32(Console.ReadLine());
            int secondValue = Convert.ToInt32(Console.ReadLine());
            int addition = firstValue + secondValue;
            int subtraction = firstValue - secondValue;
            int multiplication = firstValue * secondValue;
            double division = (double)firstValue / secondValue;
            Console.WriteLine("{0}", addition);
            Console.WriteLine("{0}", subtraction);
            Console.WriteLine("{0}", multiplication);
            Console.WriteLine("{0}", division);
        }
    }
}
