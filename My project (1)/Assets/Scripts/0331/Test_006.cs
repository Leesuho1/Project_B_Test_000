using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_006 : MonoBehaviour
{
    public int[] array = new int[5];            //배열 5개 공간을 선언하고 이름을 array라고 한다.
    public int[] points = { 83, 99, 52, 93, 15 };
    void Start()
    {
        array[0] = 2;                           //각각 배열에 정술을 직접 입력
        array[1] = 10;
        array[2] = 5;
        array[3] = 15;
        array[4] = 3;

        for (int i = 0; i < 5; i++)             //for문을 통해서 console 창에 모든 Array 배열 안에 있는 0~4까지 내용을 표시
            {                                  
            Debug.Log(array[i]); 
            }


        for(int i=0; i<points.Length; i++)      //배열의 길이를 가져오는 변수 (배열이름.Lengths) => 숫자로 나온다 -->5
        {
            if (points[i] > 90)                 //points[i] 각각 for을 돌면서 비교해서 90이 넘는 숫자만 프린트 한다
            {
                Debug.Log(points[i]);
            }
        }

        int sum = 0;                            //합 값을 구하기 위해서 입시적으로 sum 변수 선언
        for (int i = 0; i < points.Length; i++)
        {
            sum += points[i];                   //선언된 배열의 합 값
        }

        int average = sum / points.Length;      //배열의 합 값에서 배열 길이 만큼 나눈다. (평균값)

        Debug.Log(average);                     //평균값을 출력한다.

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
