using System;
using System.Collections.Generic;
//https://school.programmers.co.kr/learn/courses/30/lessons/76502
//괄호 회전하기
//Substring를 쓰면 최대 10ms걸림
//밑처럼 바꾸면 최대 8ms 걸림. Substring가 좀 많이 걸리는 듯
public class Solution
{
    public int solution(string s)
    {
        Dictionary<char, int> m = new();
        m['('] = 0;
        m[')'] = 1;
        m['{'] = 2;
        m['}'] = 3;
        m['['] = 4;
        m[']'] = 5;
        int answer = 0;
        for (int i = 0; i < s.Length; i++)
        {
            // string now = s.Substring(i, s.Length - i) + s.Substring(0, i);
            Stack<char> last = new();
            bool check = true;
            // foreach(char ii in now){
            for (int j = 0; j < s.Length; j++)
            {
                char ii = s[(i + j) % s.Length]; //이건 c++에서도 많이 쓰던 테크닉
                if (m[ii] % 2 == 0)
                {
                    last.Push(ii);
                }
                else if (last.Count == 0)
                {
                    check = false;
                    break;
                }
                else
                {
                    char lastii = last.Pop();
                    if (m[lastii] + 1 != m[ii])
                    {
                        check = false;
                        break;
                    }
                }
            }
            if (check && last.Count == 0)
            {
                answer++;
            }
        }
        return answer;
    }
}