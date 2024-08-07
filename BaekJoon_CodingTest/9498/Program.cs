namespace _9498
{
    /// <summary>
    /// 날짜 : 2024.08.06 
    /// 문제 : 시험 성적
    /// URL : https://www.acmicpc.net/problem/9498
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int input;
            int.TryParse(Console.ReadLine(), out input);

            if (90 <= input && input <= 100)
            {
                Console.WriteLine("A");
            }
            else if (80 <= input && input <= 89)
            {
                Console.WriteLine("B");
            }
            else if (70 <= input && input <= 79)
            {
                Console.WriteLine("C");
            }
            else if (60 <= input && input <= 69)
            {
                Console.WriteLine("D");
            }
            else
            {
                Console.WriteLine("F");
            }
        }
    }
}
