using System;
//https://school.programmers.co.kr/learn/courses/30/lessons/42842
//카펫
public class Solution
{
    public int[] solution(int brown, int yellow)
    {
        int[] answer = { 0, 0 };
        int all = brown + yellow;
        int limit = (int)Math.Sqrt(all);
        for (int b = 3; b <= limit; b++)
        {
            if (all % b == 0)
            {
                int a = all / b;
                if (yellow == (a - 2) * (b - 2))
                {
                    answer[0] = a;
                    answer[1] = b;
                    break;
                }
            }
        }
        return answer;
    }
}
//이차방정식으로도 풀 수 있음.
//a * b = brown + yellow
//2a + 2b - 4 = brown -> a + b = (brown + 4) / 2
//x^2 + (a+b)x + (a*b) = 0으로 만들고 근의 공식 때려박으면 된다는데 몰?루