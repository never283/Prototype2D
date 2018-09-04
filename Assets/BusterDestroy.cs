using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BusterDestroy : MonoBehaviour
{
    int EHp; //敵のＨＰ
    int BusterPower = 5; //通常攻撃の攻撃力

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        Destroy(this.gameObject);


    }


    private void OnTriggerEnter2D(Collider2D collision)　//衝突した時
    {
        if (collision.gameObject.tag == "Enemy")　//タグがEnemyの場合
        {
            GameObject.Find("enemyUnityChan").GetComponent<EnemyController>().hp

            -= BusterPower;　//敵のＨＰにダメージを与える

        }
    }

}