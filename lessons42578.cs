using System;
using System.Collections.Generic;
//https://school.programmers.co.kr/learn/courses/30/lessons/42578
//의상
//이 경우는 이중for문으로 해결하려다가 시간초과 지옥에 빠짐.
//결국 안입는 경우의 수를 각 부분에 +1한 후에 마지막에 다 벗은 상태를 빼서 구함. 빡대가리 이슈
public class Solution
{
    public int solution(string[,] clothes)
    {
        int answer = 1;
        Dictionary<string, List<string>> d = new();
        for (int i = 0; i < clothes.GetLength(0); i++)
        {
            if (!d.ContainsKey(clothes[i, 1]))
            {
                d[clothes[i, 1]] = new List<string>();
            }
            d[clothes[i, 1]].Add(clothes[i, 0]);
        }
        foreach (KeyValuePair<string, List<string>> i in d)
        {
            answer *= i.Value.Count + 1;
        }
        answer--;
        return answer;
    }
}