using System;
//https://school.programmers.co.kr/learn/courses/30/lessons/12911
//다음 큰 숫자

class Solution
{
    public int solution(int n)
    {
        char[] ac = ("0" + Convert.ToString(n, 2)).ToCharArray();
        bool check = false;
        int one = 0;
        int idx = 0;
        for (int i = ac.Length - 1; i > 0; i--)
        {
            if (ac[i - 1] == '0' && ac[i] == '1')
            {
                idx = i;
                ac[i - 1] = '1';
                ac[i] = '0';
                break;
            }
            else if (ac[i] == '1')
            {
                one++;
            }
        }
        for (int i = idx + 1; i < ac.Length; i++)
        {
            if (ac.Length - 1 - i < one)
            {
                ac[i] = '1';
            }
            else
            {
                ac[i] = '0';
            }
        }
        string s = new string(ac);
        return Convert.ToInt32(s, 2);
    }
}