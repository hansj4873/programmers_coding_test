using System;
//https://school.programmers.co.kr/learn/courses/30/lessons/12980
//점프와 순간 이동
//top down dp로 풀긴 했는데, 이진수문제에 가깝다고 함.
class Solution
{
    public void dp(int now, int res, ref int answer)
    {
        if (res >= answer)
        {
            return;
        }
        if (now == 0)
        {
            answer = res;
            return;
        }
        //짝수일 때는 나누는게 효율적이기 때문, 아니면 시간초과
        if (now % 2 == 0)
        {
            dp(now / 2, res, ref answer);
        }
        else
        {//그냥 쓰면 시간초과 홀수일 때만 점프하게 해야 함.
            dp(now - 1, res + 1, ref answer);
        }
    }
    public int solution(int n)
    {
        int answer = n;
        dp(n, 0, ref answer);
        return answer;
    }
}