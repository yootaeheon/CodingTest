namespace _2739
{
    /// <summary>
    /// 날짜 : 2024.08.08
    /// 문제 : 구구단
    /// URL : https://www.acmicpc.net/problem/2739
    /// </summary>

    internal class Program
    {
        static void Main(string[] args)
        {
            int A = int.Parse(Console.ReadLine());

            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine($"{A} * {i} = {A*i}");
            }
            
        }
    }
}
