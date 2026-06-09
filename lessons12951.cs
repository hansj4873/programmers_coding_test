using System;
using System.Linq;
//https://school.programmers.co.kr/learn/courses/30/lessons/12951
//JadenCase 문자열 만들기
public class Solution
{
    public string solution(string s)
    {
        string[] arr = s.Split(" ").Select(a => a.ToLower()).ToArray();
        int convertChar = 'A' - 'a';
        for (int i = 0; i < arr.Length; i++)
        {
            if (!string.IsNullOrEmpty(arr[i]) && 'a' <= arr[i][0] && arr[i][0] <= 'z')
            {
                arr[i] = char.ToUpper(arr[i][0]) + arr[i].Substring(1);
            }
        }
        string answer = string.Join(" ", arr);
        return answer;
    }
}