using System.Runtime.CompilerServices;
using System;
using System.IO;
using System.Text;
namespace _15552
{
    /// <summary>
    /// 날짜 : 2024.08.11
    /// 문제 : 빠른 A+B
    /// URL : https://www.acmicpc.net/problem/15552
    /// 설명 : 
    /// 시간 초과를 해결함
    /// string 배열에 입력한 값을 반복문으로 출력하였던 것을
    /// stringBuilder로 대체하여 해결함.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < T; i++)
            {
                string[] input = Console.ReadLine().Split();

                int.TryParse(input[0], out int A);
                int.TryParse(input[1], out int B);

                sb.Append((A+B) + "\n");
            }
            Console.WriteLine(sb);
        }
    }
}

