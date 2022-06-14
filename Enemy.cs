using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    //体力
    private int enemyHp_;

    // Start is called before the first frame update
    void Start()
    {
        //体力を生成
        enemyHp_ = 3;
    }

    public void Damage() 
    {
        //Enemyの体力を減らす
        enemyHp_ = enemyHp_ - 1;
    }

    // Update is called once per frame
    void Update()
    {
        //体力が0になったか
        if(enemyHp_ <= 0) 
        {
            //消滅
            Destroy(this.gameObject);
        }

    }
}
