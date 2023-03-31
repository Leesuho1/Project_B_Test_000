using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_007 : MonoBehaviour
{
    void SayHello()                                                     //인수도 반환값도 없는 메서드
    {
        Debug.Log("========================");
        Debug.Log("Hello");
        Debug.Log("========================");
    }

    void CallName(string name)                                          //인수가 있는 메서드
    {
        Debug.Log("Hello" + name);
    }

    int Add(int a, int b)                                               //인수와 반환값이 있는 메서드
    {
        int c = a + b;
        return c;                                                       //int로 함수를 선언했기 때문에 return도 int 여야 함
    }
    void Start()
    {
        CallName("Tom");
        CallName("Harry");
        CallName("Lara");

        int answer;                                                 //변수 answer를 선언했다.
        answer = Add(2, 3);                                         //메서드를 호출해서 2,3의 값을 입력해준다. 그리고 return 값을 answer에 대입해준다.
        Debug.Log(answer);
        Debug.Log(Add(7, 9));                                       //함수를 변수에 넣지 않고도 Debug.Log의 인수로 사용 할 수 있다.
    }

    
}
