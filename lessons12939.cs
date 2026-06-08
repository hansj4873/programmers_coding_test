using System;
using System.Linq;
//https://school.programmers.co.kr/learn/courses/30/lessons/12939?language=csharp
//최댓값과 최솟값
public class Solution
{

    public string solution(string s)
    {
        string answer = "";
        int[] arr = s.Split(" ").Select(a => int.Parse(a)).OrderBy(b => b).ToArray();
        answer = arr.First().ToString() + " " + arr.Last().ToString();
        return answer;
    }
}