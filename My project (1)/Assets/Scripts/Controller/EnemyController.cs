using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed = 5.0f;          //���� �ӵ� ����
    public float roationSpeed=1.0f;     //���� ��ž ȸ�� �ӵ�

    public GameObject bulletPrefab;     //�Ѿ� ������
    public GameObject enemytPivot;       //�� ��ž �Ǻ�

    public Transform firePoint;     //�߻� ��ġ
    public float fireRate = 1.0f;   //�߻� �ӵ�
    public float nextFireTime;

    private Rigidbody rb;           //rigidbody ����
    private Transform player;       //�÷��̾� ��ġ �������� ���� ����
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();                 //������ �� �ڱ� �ڽ��� rigidbody�� �޾ƿ´�
        player = GameObject.FindGameObjectWithTag("Player").transform; //Scene���� player Tap�� ���� ������Ʈ�� �����ͼ� transform�� ����
    }

    // Update is called once per frame
    void Update()
    {   
        if(player != null)
        { 
        if(Vector3.Distance(player.position , transform.position) > 1.0f)                 // Vector3.Distance <==�Ÿ��� �˷��ִ� �Լ� 
         {
            Vector3 direction = (player.position - transform.position).normalized;      //�� ���͸� ���� Nomalized �ϸ� ���� ���� �˷���
            rb.MovePosition(transform.position + direction * speed * Time.deltaTime);   //�÷��̾ ���ؼ� ������ speed�ӵ��� �̵�
         }

        //��ž ȸ��
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