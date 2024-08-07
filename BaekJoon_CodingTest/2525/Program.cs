using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace _2525
{
    /// <summary>
    /// 날짜 : 2024.08.06 
    /// 문제 : 오븐 시계
    /// URL : https://www.acmicpc.net/problem/2525
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            int h = int.Parse(input[0]);                                                       //890 60 16
            int m = int.Parse(input[1]);  

            int cook = int.Parse(Console.ReadLine());

            m += 60 * h + cook;
            
            if (m > 1439)
            {
                m = m - (24 * 60);
            }

            h = m / 60;
            m %= 60;

            Console.WriteLine($"{h} {m}");
        }
    }
}