namespace _10430
{
    /// <summary>
    /// 날짜 : 2024.08.05 
    /// 문제 : 나머지
    /// URL : https://www.acmicpc.net/problem/10430
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

            int C;
            int.TryParse(input[2], out C);

            Console.WriteLine((A + B) % C);
            Console.WriteLine(((A % C) + (B % C)) % C);
            Console.WriteLine((A * B) % C);
            Console.WriteLine(((A % C) * (B % C)) % C);
        }
    }
}
