namespace _11382
{
    /// <summary>
    /// 날짜 : 2024.08.05 
    /// 문제 : 꼬마 정민 
    /// URL : https://www.acmicpc.net/problem/11382
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            long A;                           //자료형 int는 +-21억 까지밖에 안 됨. 조건에 유의하여 long 자료형을 사용
            long.TryParse(input[0], out A);

            long B;
            long.TryParse(input[1], out B);

            long C;
            long.TryParse(input[2], out C);

            Console.WriteLine(A + B + C);
        }
    }
}
