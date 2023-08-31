using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadBook.CsharpBasic.Chapter03.Works
{
    internal class Pr001
    {
        public void Run()
        {
            Console.WriteLine("숫자를 입력하세요.");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number > 0)
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine("{0}는 짝수입니다.", number);
                }
                else
                {
                    Console.WriteLine("{0}는 홀수입니다.", number);
                }
            }
            else if (number < 0)
            {
                Console.WriteLine("{0}는 음수입니다.", number);
            }
            else
            {
                Console.WriteLine("{0}는 0입니다.", number);
            }
        }
    }
}
