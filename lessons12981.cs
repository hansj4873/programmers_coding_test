using System;
using System.Collections.Generic;
//https://school.programmers.co.kr/learn/courses/30/lessons/12981
//영어 끝말잇기
class Solution
{
    public int[] solution(int n, string[] words)
    {
        HashSet<string> s = new HashSet<string>();
        int[] answer = { 0, 0 };
        char lastWord = words[0][0];
        int end = -1;
        for (int i = 0; i < words.Length; i++)
        {
            if (lastWord != words[i][0] || s.Contains(words[i]))
            {
                end = i;
                break;
            }
            s.Add(words[i]);
            lastWord = words[i][words[i].Length - 1];
        }
        if (end != -1)
        {
            answer[0] = end % n + 1;
            answer[1] = end / n + 1;
        }
        return answer;
    }
}