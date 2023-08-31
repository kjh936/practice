using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadBook.CsharpBasic.Chapter03.Works
{
    internal class Pr002
    {
        public void Run()
        {
            Console.WriteLine("영화 제목을 입력해주세요.");
            string movieName = Console.ReadLine();
            Console.WriteLine("영화 평점을 입력해주세요.");
            int movieRate = Convert.ToInt32(Console.ReadLine());

            switch (movieRate)
            {
                case 1:
                    {
                        Console.WriteLine("{0} 영화는 환불을 받고싶을 정도로 최악의 영화군요", movieName);
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("{0} 영화는 지루한 영화군요", movieName);
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("{0} 영화는 시간 때우기 좋은 그 이상 그 이하도 아닌 영화군요", movieName);
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("{0} 영화는 흥미을 유발한 만한 완성도 높은 영화군요", movieName);
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("{0} 영화는 당신의 최고의 영화 중 하나로 기억되겠군요", movieName);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("평점 계산에 실패했습니다.");
                        break;
                    }
            }
        }
    }
}
