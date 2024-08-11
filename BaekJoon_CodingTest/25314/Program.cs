namespace _25314
{
    /// <summary>
    /// 날짜 : 2024.08.11
    /// 문제 : 코딩은 체육과목 입니다
    /// URL : https://www.acmicpc.net/problem/25314
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int i = N / 4;

            for (int j = 0; j < i; j++)
            {
                Console.Write("long ");
            }
            Console.WriteLine("int");
        }
    }
}
