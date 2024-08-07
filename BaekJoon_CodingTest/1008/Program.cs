namespace _1008
{
    /// <summary>
    /// 날짜 : 2024.08.05 
    /// 문제 : A/B
    /// URL : https://www.acmicpc.net/problem/1008
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            double A;
            double.TryParse(input[0], out A);

            double B;
            double.TryParse(input[1], out B);

            Console.WriteLine(A / B);
        }
    }
}
