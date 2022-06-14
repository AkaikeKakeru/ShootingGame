using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    //�����蔻��
    void OnTriggerEnter(Collider other) 
    {
        //Enemy�ɓ���������
        if(other.gameObject.tag == "Enemy") 
        {
            //���������I�u�W�F�N�g��Enemy�X�N���v�g���Ăяo��
            //Damage�֐������s������
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
