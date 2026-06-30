using System;
using System.Collections.Generic;
//https://school.programmers.co.kr/learn/courses/30/lessons/131127
//할인 행사
public class Solution
{
    bool check(Dictionary<string, int> wantD, Dictionary<string, int> now)
    {
        foreach (KeyValuePair<string, int> i in wantD)
        {
            if (!now.TryGetValue(i.Key, out int a) || a != i.Value)
            {
                return false;
            }
        }
        return true;
    }
    public int solution(string[] want, int[] number, string[] discount)
    {
        int answer = 0;
        Dictionary<string, int> wantD = new();
        Dictionary<string, int> now = new();
        for (int i = 0; i < want.Length; i++)
        {
            wantD[want[i]] = number[i];
        }
        for (int i = 0; i < 10; i++)
        {
            now[discount[i]] = now.ContainsKey(discount[i]) ? now[discount[i]] + 1 : 1;
        }
        if (check(wantD, now))
        {
            answer++;
        }
        for (int i = 10; i < discount.Length; i++)
        {
            now[discount[i]] = now.ContainsKey(discount[i]) ? now[discount[i]] + 1 : 1;
            now[discount[i - 10]]--;
            if (check(wantD, now))
            {
                answer++;
            }
        }
        return answer;
    }
}