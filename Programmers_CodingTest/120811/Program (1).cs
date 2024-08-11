namespace _120811
{
    /// <summary>
    /// 날짜 : 2024.08.09
    /// 문제 : 중앙 값 구하기
    /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120811
    /// </summary>
    public class Solution
    {
        public int solution(int[] array)
        {
            int A = array.Length / 2;

            Array.Sort(array);
            int answer = array[A];
            return answer;
        }
    }
}
