namespace _25304
{
    /// <summary>
    /// 날짜 : 2024.08.10
    /// 문제 : 영수증
    /// URL : https://www.acmicpc.net/problem/25304
    /// </summary>

    internal class Program
    {
        static void Main(string[] args)
        {
            int X = int.Parse(Console.ReadLine());

            int N = int.Parse(Console.ReadLine());
            int answer = 0;

            for (int i = 0; i < N; i++)
            {
                string[] input = Console.ReadLine().Split();
                int a = int.Parse(input[0]);
                int b = int.Parse(input[1]);
                
                answer += a * b;
            }

            if (answer == X)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
