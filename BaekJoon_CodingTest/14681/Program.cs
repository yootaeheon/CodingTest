namespace _14681
{
    /// <summary>
    /// 날짜 : 2024.08.06 
    /// 문제 : 사분면 고르기
    /// URL : https://www.acmicpc.net/problem/14681
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            int.TryParse(Console.ReadLine(), out x);

            int y;
            int.TryParse(Console.ReadLine(), out y);

            switch (x)
            {
                case > 0 :
                    if (y > 0)
                    { Console.WriteLine("1"); }
                    if (y < 0)
                    { Console.WriteLine("4"); }
                    break;
                case < 0 :
                    if (y > 0)
                    { Console.WriteLine("2"); }
                    if (y < 0)
                    { Console.WriteLine("3"); }
                    break;
            }
        }
    }
}
