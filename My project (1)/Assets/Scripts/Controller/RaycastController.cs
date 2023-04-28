using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastController : MonoBehaviour
{
    public GameObject Monster;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Ray cast = Camera.main.ScreenPointToRay(Input.mousePosition);                       //화면에서의 2차원 마우스 좌표를 입력해서 3d 카메라에서 RAY를 만드는 함수

            RaycastHit hit;

            if (Physics.Raycast(cast, out hit))      //Rast 가 충돌 감지된 것을 hit 로 돌려준다.
            {
                if(hit.collider.tag =="Plane")
                {
                    GameObject temp = (GameObject) Instantiate(Monster);
                    temp.transform.position = hit.point + new Vector3(0.0f, 1.0f, 0.0f);
                }
                Debug.Log(hit.collider.name);

                Debug.DrawLine(cast.origin, hit.point, Color.red, 2.0f);     //Ray가 쏴지는 것을 가시적으로 보여준다.
            }
        }

    }
}
