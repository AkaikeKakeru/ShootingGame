using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    //�̗�
    private int enemyHp_;

    // Start is called before the first frame update
    void Start()
    {
        //�̗͂𐶐�
        enemyHp_ = 3;
    }

    public void Damage() 
    {
        //Enemy�̗̑͂����炷
        enemyHp_ = enemyHp_ - 1;
    }

    // Update is called once per frame
    void Update()
    {
        //�̗͂�0�ɂȂ�����
        if(enemyHp_ <= 0) 
        {
            //����
            Destroy(this.gameObject);
        }

    }
}
