using System;
//https://school.programmers.co.kr/learn/courses/30/lessons/42747
//H-Index
//처음은 최악 0.66ms
//람다식은 기본 오버헤드가 있기 때문에 이런 정형화된 정렬(여기서는 내림차순)을 할 때는 다음과 같은 방법을 씀
//Array.Sort(citations) -> Array.Reverse(citations)로 기본적으로 주어지는 함수를 쓰거나
//Array.Sort(citations)만 하고 역순으로 찾는 것이 더 빠르다고 하는데.
//했던 결과가 최악 1.33ms
//잼민이가 평균적으로 저게 더 빠르다는데. 일단 하던데로 가장빠른 코드 빼고 주석처리함.
//잼민이 쉑 따잇
public class Solution
{
    public int solution(int[] citations)
    {
        int answer = 0;
        Array.Sort(citations, (a, b) => b.CompareTo(a));
        // Array.Sort(citations);
        // Array.Reverse(citations);
        for (int i = 0; i < citations.Length; i++)
        {
            // if(i >= citations[i]){
            //     return i;
            // }
            answer++;
            if (answer > citations[i])
            {
                answer--;
                break;
            }
        }
        // return citations.Length;
        return answer;
    }
}