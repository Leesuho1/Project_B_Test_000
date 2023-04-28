using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed = 5.0f;

    private Rigidbody rb;           //rigidbody 선언
    private Transform player;       //플레이어 위치 가져오기 위해 선언
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();                 //시작할 때 자기 자신의 rigidbody를 받아온다
        player = GameObject.FindGameObjectWithTag("Player").transform; //Scene에서 player Tap를 가진 오브젝트를 가져와서 transform을 참조
    }

    // Update is called once per frame
    void Update()
    {   
        if(Vector3.Distance(player.position , transform.position) > 1.0f)                 // Vector3.Distance <==거리를 알려주는 함수 
        {
            Vector3 direction = (player.position - transform.position).normalized;      //두 벡터를 뻬고 Nomalized 하면 방향 값을 알려줌
            rb.MovePosition(transform.position + direction * speed * Time.deltaTime);   //플레이어를 향해서 설정한 speed속도로 이동
        }
    }
}
