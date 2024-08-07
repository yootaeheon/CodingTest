namespace _1000
{
    /// <summary>
    /// 날짜 : 2024.08.05 
    /// 문제 : A+B
    /// URL : https://www.acmicpc.net/problem/1000
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            int A;
            int.TryParse(input[0], out A);

            int B;
            int.TryParse(input[1], out B);

            Console.WriteLine(A + B);
        }
    }
}
