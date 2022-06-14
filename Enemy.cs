using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    //‘Ì—Í
    private int enemyHp_;

    // Start is called before the first frame update
    void Start()
    {
        //‘Ì—Í‚ğ¶¬
        enemyHp_ = 3;
    }

    public void Damage() 
    {
        //Enemy‚Ì‘Ì—Í‚ğŒ¸‚ç‚·
        enemyHp_ = enemyHp_ - 1;
    }

    // Update is called once per frame
    void Update()
    {
        //‘Ì—Í‚ª0‚É‚È‚Á‚½‚©
        if(enemyHp_ <= 0) 
        {
            //Á–Å
            Destroy(this.gameObject);
        }

    }
}
