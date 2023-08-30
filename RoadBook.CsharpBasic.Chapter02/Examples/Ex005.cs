using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadBook.CsharpBasic.Chapter02.Examples
{
    internal class Ex005
    {
        public void Run()
        {
            object objHello = "Hello World";
            var vHello = "Hello World";
            dynamic dHello = "Hello World";
            
            bool inContainsWord01 = objHello.ToString().Contains("Hello");
            bool inContainsWord02 = vHello.Contains("Hello");
            bool inContainsWord03 = dHello.Contains("Hello");

            Console.WriteLine("object 변수에 Hello가 포함되어 있다 ? {0}", inContainsWord01);
            Console.WriteLine("var 변수에 Hello가 포함되어 있다 ? {0}", inContainsWord02);
            Console.WriteLine("dynamic 변수에 Hello가 포함되어 있다 ? {0}", inContainsWord03);
        }
    }
}
