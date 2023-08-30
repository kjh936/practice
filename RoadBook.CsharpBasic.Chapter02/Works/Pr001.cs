using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace RoadBook.CsharpBasic.Chapter02.Works
{
    internal class Pr001
    {
        public void Run()
        {
            Console.WriteLine("숫자를 차례대로 입력하세요.");
            int firstValue = Convert.ToInt32(Console.ReadLine());
            int secondValue = Convert.ToInt32(Console.ReadLine());
            bool whichIsBigger = firstValue > secondValue;
            Console.WriteLine("{0}", whichIsBigger);
        }
    }
}
