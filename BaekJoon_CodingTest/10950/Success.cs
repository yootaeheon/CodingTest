namespace _10950
{
    internal class Success
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine()); // T 입력 받음

            int[] answer = new int[T]; // A + B 값을 저장할 배열 생성

            for (int i = 0; i < T; i++) // 입력 받은 수 더하여 answer 배열에 저장을 반복 
            {
                string[] input = Console.ReadLine().Split();
                int A = int.Parse(input[0]);
                int B = int.Parse(input[1]);

                answer[i] = A+B;
            }

            for (int i = 0; i < T; i++) // 출력
            {
                Console.WriteLine(answer[i]);
            }
        }
    }
}
