using System;
using System.Numerics; //이건 밑의 코드에서 쓰는 거
//https://school.programmers.co.kr/learn/courses/30/lessons/12985
//예상 대진표
//주석처리된 거 보다 그냥 계산 하는게 좀 더 논리적이고 빠름
//주석처리된 코드는 0.12 ~ 0.15ms
//현 코드는 0.09~0.12ms
class Solution
{
    // int convert(int n){
    //     if(n % 2 == 0){
    //         return n / 2;
    //     }
    //     else{
    //         return n / 2 + 1;
    //     }
    // }
    public int solution(int n, int a, int b)
    {
        int answer = 1;
        if (a > b)
        {
            (a, b) = (b, a);
        }
        while (true)
        {
            // if(b % 2 == 0 && b - 1 == a){
            //     break;
            // }
            // a = convert(a);
            // b = convert(b);
            a = (a + 1) / 2;
            b = (b + 1) / 2;
            if (a == b)
            {
                break;
            }
            answer++;
        }
        return answer;
    }
}
//근데 밑의 방식으로 하면 더 빠르다고 함.
//제미나이 피셜
//이 문제는 두 숫자를 이진수로 표현했을 때 "뒤에서부터 몇 번째 비트에서 서로 달라지는가"와 완벽하게 일치한다고 함
//BitOperations는 using System.Numerics; 해야함.
//(a - 1) ^ (b - 1)는 xor, 즉 서로 다른 비트일때만 1임 이걸로 서로 다른 비트들을 구하고
//BitOperations.Log2는 가장 왼쪽에 있는 1(최상위 비트, MSB)이 몇 번째 인덱스에 있는가?"를 구하고 소수점 아래는 그냥 통째로 버려버리는(Floor) 함수
//쉽게 말하면 루트2하고 소수점을 버림, 즉 숫자가 2**n ~ 2**n+1에 있으니까 n을 찾아주는 함수
//uint를 써주는 이유는 함수가 uint만 먹어서, 자세한 이유는 모름, 함수 개발한 개발자한테 뭐라고 하셈.
//이건 0.06~0.09ms 개빠름
class Solution
{
    public int solution(int n, int a, int b)
    {
        //+1 해주는 이유는 1라운드부터 시작이라서
        return BitOperations.Log2((uint)((a - 1) ^ (b - 1))) + 1;
    }
}