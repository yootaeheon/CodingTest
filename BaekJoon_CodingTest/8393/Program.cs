namespace _8393
{
    /// <summary>
    /// 날짜 : 2024.08.08
    /// 문제 : 합
    /// URL : https://www.acmicpc.net/problem/8393
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }

            Console.WriteLine($"{sum}");
        }
    }
}
