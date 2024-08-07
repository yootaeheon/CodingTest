namespace _2588
{
    /// <summary>
    /// 날짜 : 2024.08.05 
    /// 문제 : 곱셈
    /// URL : https://www.acmicpc.net/problem/2588
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int A;
            int.TryParse(Console.ReadLine(), out A);

            int B;
            int.TryParse(Console.ReadLine(), out B);

            Console.WriteLine(A * (B%10));
            Console.WriteLine(A * ((B % 100)/10)); 
            Console.WriteLine(A * (B/100)); 
           
            Console.WriteLine(A * B);
        }
    }
}
