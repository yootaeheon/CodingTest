namespace _1330
{
    /// <summary>
    /// 날짜 : 2024.08.06
    /// 문제 : 두 수 비교하기
    /// URL : https://www.acmicpc.net/problem/1330
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

            if (A == B)
            {
                Console.WriteLine("==");
            }
            if (A > B)
            {
                Console.WriteLine(">");
            }
            if (A < B)
            {
                Console.WriteLine("<");
            }
        }
    }
}
