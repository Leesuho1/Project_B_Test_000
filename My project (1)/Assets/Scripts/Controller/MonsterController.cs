using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterController : MonoBehaviour
{
    public int Monster_hp = 5;

    public void Monster_Damaged(int damage) //데미지 받는 
    {
        Monster_hp -= damage;               //데미지를 뺀다.

        if(Monster_hp <= 0)
        {
            GameObject temp = this.gameObject;      //나 자신을 가져와서 temp에 입력
            Destroy(temp);

        }
    }
}
