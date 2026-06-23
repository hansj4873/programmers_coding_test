using System;
using System.Collections.Generic;
//https://school.programmers.co.kr/learn/courses/30/lessons/131701
//연속 부분 수열 합의 개수
public class Solution
{
    public int solution(int[] elements)
    {
        HashSet<int> s = new HashSet<int>();
        int[] arr = new int[elements.Length * 2 - 1];
        for (int i = 0; i < elements.Length * 2 - 1; i++)
        {
            arr[i] = elements[i % elements.Length];
        }
        for (int i = 1; i <= elements.Length; i++)
        {
            int now = 0;
            for (int ii = 0; ii < i; ii++)
            {
                now += arr[ii];
            }
            s.Add(now);
            for (int ii = 1; ii < elements.Length; ii++)
            {
                now -= arr[ii - 1];
                now += arr[ii + i - 1];
                s.Add(now);
            }
        }
        return s.Count;
    }
}
//근데 이게 더 빠름, hashset은 아무래도 만들어진 클래스라서 클래식한테 속도에서 밀림
//위 문제 대비 약 3~5배 빠름, 아무래도 커지면 커질수록 효율이 좋은 것이지 
public class Solution
{
    public int solution(int[] elements)
    {
        bool[] s = new bool[1000001];
        int c = 0;
        int[] arr = new int[elements.Length * 2 - 1];
        for (int i = 0; i < elements.Length * 2 - 1; i++)
        {
            arr[i] = elements[i % elements.Length];
        }
        for (int i = 1; i <= elements.Length; i++)
        {
            int now = 0;
            for (int ii = 0; ii < i; ii++)
            {
                now += arr[ii];
            }
            if (!s[now])
            {
                s[now] = true;
                c++;
            }
            for (int ii = 1; ii < elements.Length; ii++)
            {
                now -= arr[ii - 1];
                now += arr[ii + i - 1];
                if (!s[now])
                {
                    s[now] = true;
                    c++;
                }
            }
        }
        return c;
    }
}