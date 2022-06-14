using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    //当たり判定
    void OnTriggerEnter(Collider other) 
    {
        //Enemyに当たったか
        if(other.gameObject.tag == "Enemy") 
        {
            //当たったオブジェクトのEnemyスクリプトを呼び出す
            //Damage関数を実行させる
            other.GetComponent<Enemy>().Damage();
            Destroy(this.gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;

        pos.z += 0.05f;

        transform.position = new Vector3(pos.x, pos.y, pos.z);

        if(pos.z >= 20)
        {
            Destroy(this.gameObject);
        }
    }
}
