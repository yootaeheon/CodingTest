using System;
using System.Linq;

namespace _120899
{
    /// <summary>
    /// 날짜 : 2024.08.09
    /// 문제 : 가장 큰 수 찾기
    /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120899
    /// </summary>
    public class Solution
    {
        public int[] solution(int[] array)
        {
            int[] answer = new int[2];

            int maxNum = array.Max();
            int maxNumIndex = Array.IndexOf(array, maxNum);

            answer[0] = maxNum;
            answer[1] = maxNumIndex;

            return answer;
        }
    }
}
