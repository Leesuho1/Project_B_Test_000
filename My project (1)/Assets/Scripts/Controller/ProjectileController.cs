using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileController : MonoBehaviour
{
    public Vector3 launchDirection;                                                 //발사 방향 벡터 선언
    public GameObject Projectile;                                                   //발사체 프리맵 선언
   
   public void FireProjectile()                                         //발사체 함수 선언
    {
        GameObject temp = (GameObject)Instantiate(Projectile);                       //발사체 프리맵을 생성 시키고 temp 에 입력       
                                                                                     //instantiate 함수는 GameObject , 프리팹을 생성 시킨다.
        temp.transform.position = this.gameObject.transform.position;
        temp.GetComponent<ProjectileMove>().launchDirection = transform.forward;

        Destroy(temp, 10f);     //발사체 만든 것이 10초후에 사라진다.
    }

    
    
}
