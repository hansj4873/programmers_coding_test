using System;
using System.Linq;
using System.Collections.Generic;
//https://school.programmers.co.kr/learn/courses/30/lessons/138476
//귤 고르기
public class Solution
{
    public int solution(int k, int[] tangerine)
    {
        Dictionary<int, int> map = tangerine.GroupBy(a => a).ToDictionary(b => b.Key, b => b.Count());
        List<KeyValuePair<int, int>> l = new List<KeyValuePair<int, int>>(map);
        l.Sort((a, b) => b.Value.CompareTo(a.Value));
        int c = 0;
        foreach (var i in l)
        {
            if (k <= 0)
            {
                break;
            }
            c++;
            k -= i.Value;
        }
        return c;
    }
}
//Linq때문에 좀 느림, 원래 Linq가 제네릭 sort나 array sort보다 느림