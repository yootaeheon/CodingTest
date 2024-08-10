using System;
using System.Linq;

namespace _12915
{
    /// <summary>
    /// 날짜 : 2024.08.09
    /// 문제 : 문자열 내 마음대로 정렬하기 
    /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/12915
    /// </summary>
    public class Solution
    {
        public string[] solution(string[] strings, int n)
        {
            string[] answer = new string[] { };
            answer = strings.OrderBy(x => x).OrderBy(x => x[n]).ToArray();
            return answer;
        }
    }
}
