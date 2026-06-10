using System;
using System.Linq;
//https://school.programmers.co.kr/learn/courses/30/lessons/12941?language=csharp
//최솟값 만들기
public class Solution
{
    public int solution(int[] A, int[] B)
    {
        int answer = 0;
        A = A.OrderBy(a => a).ToArray();
        B = B.OrderByDescending(a => a).ToArray();
        for (int i = 0; i < A.Length; i++)
        {
            answer += A[i] * B[i];
        }
        return answer;
    }
}