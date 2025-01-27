using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        // 비제네릭 컬렉션 ArrayList 사용
        ArrayList arrayList = new ArrayList();

        // 다양한 타입의 데이터를 추가
        arrayList.Add(1);            // 정수 추가
        arrayList.Add("hello");      // 문자열 추가
        arrayList.Add(3.14);         // 실수 추가

        // 데이터를 처리할 때 타입 변환 문제 발생 가능
        try
        {
            foreach (var item in arrayList)
            {
                // 모든 데이터를 정수로 처리하려고 시도
                int number = (int)item; // 문자열이나 실수를 정수로 변환하려고 하면 예외 발생
                Console.WriteLine(number);
            }
        }
        catch (InvalidCastException ex)
        {
            Console.WriteLine($"오류 발생: {ex.Message}");
        }
    }
}
