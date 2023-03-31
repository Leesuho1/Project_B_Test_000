using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player
{
    private int hp = 100;                                  //���� Hp�� Private �ϰ� ���� 100 �Է�
    private int Power = 50;                                //���� Power�� Private �ϰ� ���� 50 �Է�


    public void Attack()                                    //�޼ҵ� Attack ����
    {
        Debug.Log(this.Power + "�������� ������.");
    }
    public void Damage(int damage)                          //�޼ҵ� Damage ����
    {
        this.hp -= damage;
        Debug.Log(damage + "�������� �Ծ���.");
    }
    public int GetHp()
    {
        return hp;
    }
}


public class Test_008 : MonoBehaviour
{
    public Text PlayerHp;                                   //Player Hp �����ִ� UI
    public Text Player2Hp;                                  //Player Hp �����ִ� UI

    Player mPlayer = new Player();
    Player mPlayer2 = new Player();
    // Start is called before the first frame update
    void Start()
    {
                            
       // mPlayer.Attack();                                     //Player �޼ҵ� Attack ȣ��
        //mPlayer.Damage(30);                                  //Player �޼ҵ� Damage ȣ��
       // Debug.Log(mPlayer.GetHp());                           //Player�� Hp�� �����ش�.
    }

    // Update is called once per frame
    void Update()
    {
        PlayerHp.text = "Player1 Hp" + mPlayer.GetHp().ToString();
        Player2Hp.text = "Player2 Hp" + mPlayer2.GetHp().ToString();

        if (Input.GetMouseButtonDown(0))                        //���� ���콺 
        {
            mPlayer.Damage(1);
        }
        if (Input.GetMouseButtonDown(1))
        {
            mPlayer2.Damage(1);
        }
    }
}
