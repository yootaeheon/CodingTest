namespace _10998
{
    /// <summary>
    /// 날짜 : 2024.08.05 
    /// 문제 : AXB
    /// URL : https://www.acmicpc.net/problem/10998
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

            Console.WriteLine(A * B);
        }
    }
}
