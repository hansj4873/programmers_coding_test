using System;
//https://school.programmers.co.kr/learn/courses/30/lessons/12949
//행렬의 곱셈
//a X b * c X d 일 때 b와 c가 같아야함
//와 근데 c#은 c++보다 편하게 길이를 불러오는 GetLength(0)가 있음 개쩜
public class Solution
{
    public int[,] solution(int[,] arr1, int[,] arr2)
    {
        int[,] answer = new int[arr1.GetLength(0), arr2.GetLength(1)];
        for (int i = 0; i < arr1.GetLength(0); i++)
        {
            for (int ii = 0; ii < arr2.GetLength(1); ii++)
            {
                answer[i, ii] = 0;
                for (int iii = 0; iii < arr1.GetLength(1); iii++)
                {
                    answer[i, ii] += arr1[i, iii] * arr2[iii, ii];
                }
            }
        }
        return answer;
    }
}