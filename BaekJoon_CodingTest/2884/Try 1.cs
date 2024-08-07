namespace _2884
{
    /// <summary>
    /// 날짜 : 2024.08.06 
    /// 문제 : 알람시계
    /// URL : https://www.acmicpc.net/problem/2884
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            int H;
            int.TryParse(input[0], out H);

            int M;
            int.TryParse(input[1], out M);

            int ch; // 일반 기준
            ch = H * 60 + M - 45;

            int chH; //일반 기준 시간
            chH = ch / 60;                                         
                                                                   
            int chM; //일반 기준 분                                 
            chM = ch % 60;



            int chZero; // 0시 일때 기준
            chZero = (H + 24) * 60 + M - 45;
            
            int chZeroH; //0시 기준 시간
            chZeroH = chZero / 60;

            int chZeroM; //0시 기준 분
            chZeroM = chZero % 60;



            if (H > 1) //0시 아닐 때 기준
            {
                Console.WriteLine($"{chH} {chM}");
            }
            if (H == 0) //0시 기준
            {
                H = 24;
                Console.WriteLine($"{chZeroH} {chZeroM}");
            }   
        }
    }
}
