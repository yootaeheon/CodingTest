namespace _2753
{
    /// <summary>
    /// 날짜 : 2024.08.06 
    /// 문제 : 윤년
    /// URL : https://www.acmicpc.net/problem/2753
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int input;
            int.TryParse(Console.ReadLine(), out input);

            if (input % 4 == 0 && input % 100 != 0)
            {
                Console.WriteLine("1");
            }
            else if (input % 400 == 0)
            {
                Console.WriteLine("1");
            }
            else
            {
                Console.WriteLine("0");
            }
        }
    }
}
