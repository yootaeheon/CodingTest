namespace _2480
{
    /// <summary>
    /// 날짜 : 2024.08.07
    /// 문제 : 주사위 세개
    /// URL : https://www.acmicpc.net/problem/2480
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            int A = int.Parse(input[0]);

            int B = int.Parse(input[1]);

            int C = int.Parse(input[2]);

            if (A == B && B == C)
            {
                A = 10000 + A * 1000;
                Console.WriteLine(A);
            }

            else if (A == B && B != C)
            {
                A = 1000 + A * 100;
                Console.WriteLine(A);
            }
            else if (B == C && C != A)
            {
                B = 1000 + B * 100;
                Console.WriteLine(B);
            }
            else if (C == A && A != B)
            {
                C = 1000 + C * 100;
                Console.WriteLine(C);
            }

            else if  (A != B && B != C && A != C)
            {
                string MAX = input.Max();
                int max;
                int.TryParse(MAX, out max);
                max *= 100;
                Console.WriteLine(max);
            }
        }
    }
}
