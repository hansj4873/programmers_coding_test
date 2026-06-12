using System;
using System.Linq;
//https://school.programmers.co.kr/learn/courses/30/lessons/70129
//이진 변환 반복하기
public class Solution
{
    public int[] solution(string s)
    {
        int[] answer = { 0, 0 };
        int one = 0;
        while (true)
        {
            if (s.Length == 1 && one == 1)
            {
                break;
            }
            answer[0]++;
            one = s.Count(a => a == '1');
            answer[1] += s.Length - one;
            s = Convert.ToString(one, 2);
        }
        return answer;
    }
}