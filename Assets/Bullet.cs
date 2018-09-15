using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class Bullet : MonoBehaviour
{
    int EHp; //敵のＨＰ
    int BusterPower = 5; //通常攻撃の攻撃力
    private GameObject nearobj; //最も近いオブジェクト
    public GameObject UnityChan2D;
    List<GameObject> otherobjects = new List<GameObject>();
   

    // Use this for initialization
    void Start()
    {
       
      
    }

    // Update is called once per frame
    void Update()
    {

        nearobj = serchtag();


        otherobjects.Find(x => x.name == nearobj.name).
            GetComponent<EnemyController>().hp
              -= BusterPower; //敵のＨＰにダメージを与える
        Destroy(this.gameObject);
    }


    private void OnTriggerEnter2D(Collider2D collision)　//衝突した時
    {
        if(collision.tag == "Enemy")
        {
            otherobjects.Add(collision.gameObject);
        }
        


        if (nearobj) //最も近い敵ならダメージを与える 
        {
           

        }
        else
        {
            //近い敵ではないならダメージを与えない
        }
    }

        //指定されたタグの中で最も近いものを取得
        GameObject serchtag()
        {
            
            GameObject targetobj = null; //ターゲットオブジェクト

       
        //タグ指定されたオブジェクトを配列で取得する
        foreach (GameObject nearenemy in otherobjects){

            float tmpdis = 0;　　　　　　　//距離用一時変数
            float neardis = 0;      //最も近いオブジェクトの距離

            //自身と取得したオブジェクトの距離を取得
            tmpdis = Vector3.Distance(nearenemy.transform.position, UnityChan2D.transform.position);

                if(neardis == 0 || neardis > tmpdis)
                {

                    //一時変数に距離を格納
                    neardis = tmpdis;
                    targetobj = nearenemy;

                }

        }
            //最も近かったオブジェクトを返す
            return targetobj;

    }

}