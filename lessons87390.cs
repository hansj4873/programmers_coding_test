using System;
//http://school.programmers.co.kr/learn/courses/30/lessons/87390
//n^2 배열 자르기
//기존에는 Math사용하지 않고 그냥 했음 그 결과 최대 1.2ms
//근데 Math는 다른 라이브러리랑 다름.
//Maths는 컴파일러를 거치면 그냥 바로 cpu내부에 1대1로 대응되는 함수가 있음.
//->하드웨어 가속 + 병렬연산 + 어셈블리 최적화가 한줄로 처리됨. 내가 아무리 잘 구현해도 Math보다 빠르지 않음.
//예를 들어 Math.DivRem은 나누기랑 나머지를 한번에 구해줌.
//나누기, 나머지는 cpu에서는 모두 DIV함수임, 이 특성을 이용해서 두번 써서 각각 구하는게 아니라 한번에 구할 수 있게 해줌.
//math를 쓰면 최대 1.03ms가 걸림. 작은 수에서 이정도면 꽤나 큰 차이
public class Solution
{
    public int[] solution(int n, long left, long right)
    {
        int[] answer = new int[right - left + 1];
        for (long i = left; i <= right; i++)
        {
            //long col = i / n + 1, row = i % n + 1;
            long row = Math.DivRem(i, n, out long col) + 1;
            col += 1;
            //answer[(int)(i - left)] = col >= row ? (int)col : (int)row;
            answer[(int)(i - left)] = (int)Math.Max(col, row);
        }
        return answer;
    }
}