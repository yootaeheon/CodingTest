namespace _18108
{
    /// <summary>
    /// 날짜 : 2024.08.05 
    /// 문제 : 1998년생인 내가 태국에서는 2541년생?!
    /// URL : https://www.acmicpc.net/problem/18108
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int boolgi;
            int.TryParse(Console.ReadLine(), out boolgi);

            int seogi;
            seogi = boolgi - 543;

            Console.WriteLine(seogi);
        }
    }
}
