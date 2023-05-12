using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed = 5.0f;          //적의 속도 선언
    public float roationSpeed=1.0f;     //적의 포탑 회전 속도

    public GameObject bulletPrefab;     //총알 프리팹
    public GameObject enemytPivot;       //적 포탑 피봇

    public Transform firePoint;     //발사 위치
    public float fireRate = 1.0f;   //발사 속도
    public float nextFireTime;

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
        if(player != null)
        { 
        if(Vector3.Distance(player.position , transform.position) > 1.0f)                 // Vector3.Distance <==거리를 알려주는 함수 
         {
            Vector3 direction = (player.position - transform.position).normalized;      //두 벡터를 뻬고 Nomalized 하면 방향 값을 알려줌
            rb.MovePosition(transform.position + direction * speed * Time.deltaTime);   //플레이어를 향해서 설정한 speed속도로 이동
         }

        //포탑 회전
        Vector3 targetDirection = (player.position - enemytPivot.transform.position).normalized;
        Quaternion targetRotaion = Quaternion.LookRotation(targetDirection);
        enemytPivot.transform.rotation = Quaternion.Lerp(enemytPivot.transform.rotation, targetRotaion, roationSpeed * Time.deltaTime);

        if(Time.time > nextFireTime)
            {
            nextFireTime = Time.time + 1.0f / fireRate;
            GameObject temp = (GameObject)Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            temp.GetComponent<ProjectileMove>().launchDirection = firePoint.localRotation * Vector3.forward;
            temp.GetComponent<ProjectileMove>().bullettype = ProjectileMove.BULLETTYPE.ENEMY;
            }
        }
    }
}
