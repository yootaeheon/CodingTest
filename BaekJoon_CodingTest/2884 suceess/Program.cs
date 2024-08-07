using System.Runtime.CompilerServices;

namespace _2884_success
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            int h = int.Parse(input[0]);
            int m = int.Parse(input[1]);

            m += 60 * h;

            m -= 45;

            if (m < 0)
            {
                m = m + (60 * 24);
            }

            h = m / 60;
            m %= 60;

            Console.WriteLine($"{h} {m}");
        }
    }
}
