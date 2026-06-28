using System;
using System.Collections.Generic;
//https://school.programmers.co.kr/learn/courses/30/lessons/42586
//기능개발
//원래는 DivRem를 썼는데 (나누는 수) - 1을 나눠야 하는 수에 넣고 하면 알아서 올림 처리가 되는 수학기법이 있다고 함
//사실상 0.01ms정도 더 빠른 거 같음. 수가 작아서 그런 거 같음.
//[^1]는 8.0에서 부터 지원하는 문법, [^n] 뒤에서 n번째에 있는 거
public class Solution
{
    public int[] solution(int[] progresses, int[] speeds)
    {
        List<int> answer = new();
        int today = 0;
        for (int i = 0; i < progresses.Length; i++)
        {
            // int q = Math.DivRem(100 - progresses[i], speeds[i], out int r);
            // if(r != 0){
            //     q++;
            // }
            int q = (100 - progresses[i] + speeds[i] - 1) / speeds[i];
            if (q > today)
            {
                answer.Add(1);
                today = q;
            }
            else
            {
                // answer[answer.Count - 1]++;
                answer[^1]++;
            }
        }
        return answer.ToArray();
    }
}