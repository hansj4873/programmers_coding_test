using System;
//https://school.programmers.co.kr/learn/courses/30/lessons/12909
//올바른 괄호
public class Solution
{
    public bool solution(string s)
    {
        int stacked = 0;
        foreach (char c in s)
        {
            if (c == '(')
            {
                stacked++;
            }
            else
            {
                if (stacked == 0)
                {
                    return false;
                }
                stacked--;
            }
        }
        if (stacked == 0)
        {
            return true;
        }
        return false;
    }
}