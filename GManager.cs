using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GManager : MonoBehaviour
{
    //敵の数を数える
    private GameObject[] enemy_;

    //パネルを登録する
    public GameObject panel;

    // Start is called before the first frame update
    void Start()
    {
        //パネルを隠す
        panel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //シーン中に存在しているEnemyタグのオブジェクト
        enemy_ = GameObject.FindGameObjectsWithTag("Enemy");

        if(enemy_.Length == 0) 
        {
            //パネルを表示させる
            panel.SetActive(true);
        }
    }
}
