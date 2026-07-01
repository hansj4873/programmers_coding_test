using System;
using System.Collections.Generic;
//https://school.programmers.co.kr/learn/courses/30/lessons/42587
//프로세스
public class Solution
{
    public int solution(int[] priorities, int location)
    {
        int answer = 0;
        Queue<(int num, int priority)> q = new();
        for (int i = 0; i < priorities.Length; i++)
        {
            q.Enqueue((i, priorities[i]));
        }
        Array.Sort(priorities);
        int now = priorities.Length - 1;
        while (q.Count > 0)
        {
            var i = q.Dequeue();
            if (i.priority == priorities[now])
            {
                answer++;
                if (i.num == location)
                {
                    return answer;
                }
                else
                {
                    now--;
                    continue;
                }
            }
            q.Enqueue(i);
        }
        return answer;
    }
}