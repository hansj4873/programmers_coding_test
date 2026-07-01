using System;
//https://school.programmers.co.kr/learn/courses/30/lessons/87946
//피로도
//전형적인 dfs문제 근데 c#으로 dfs하는 거 처음이라 많이 헤맸다
public class Solution
{
    void dfs(ref int answer, int nowD, int nowK, int visitN, int[,] dungeons, bool[] visit)
    {
        int other = dungeons.GetLength(0) - visitN;
        if (nowD + other <= answer)
        {
            return;
        }
        if (nowD > answer)
        {
            answer = nowD;
        }
        for (int i = 0; i < dungeons.GetLength(0); i++)
        {
            if (visit[i] || nowK < dungeons[i, 0])
            {
                continue;
            }
            visit[i] = true;
            dfs(ref answer, nowD + 1, nowK - dungeons[i, 1], visitN + 1, dungeons, visit);
            visit[i] = false;
        }
    }
    public int solution(int k, int[,] dungeons)
    {
        int answer = 0;
        bool[] visit = new bool[dungeons.GetLength(0)];
        dfs(ref answer, 0, k, 0, dungeons, visit);
        return answer;
    }
}