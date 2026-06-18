//https://school.programmers.co.kr/learn/courses/30/lessons/12953
//N개의 최소공배수
//이거 그냥 n - 1 번 최소공배수 구하는 거임. 솔직히 더러워보임
public class Solution
{
    public int GCD(int a, int b)
    {
        while (a != 0 && b != 0)
        {
            if (a > b)
            {
                (a, b) = (b, a);
            }
            b %= a;
        }
        return a;
    }
    public int solution(int[] arr)
    {
        int answer = 1;
        if (arr.Length == 1)
        {
            answer = arr[0];
        }
        else
        {
            answer = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                int gcd = GCD(answer, arr[i]);
                answer *= arr[i] / gcd;
            }
        }
        return answer;
    }
}