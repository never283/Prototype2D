using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControler : MonoBehaviour {

    public int maxHP = 100;　//体力最大値

    public int HP; //体力

    public int EnemyATK = 10; //敵の攻撃力

    private GameObject hptext;

  

    // Use this for initialization
    void Start()
    {
        HP = maxHP; //初期体力を最大値にする

        this.hptext = GameObject.Find("HPText");

        

    }

    // Update is called once per frame
    void Update()
    {

        if (HP <= 0)
        {

            Debug.Log("死亡しました");

        }


    }

        void OnTriggerEnter2D(Collider hit)
        {

            if (hit.CompareTag("Attack"))
            {

                HP -= EnemyATK; //攻撃で体力が減少
                Debug.Log(HP); //HPを表示

                //UIにHPを書き込む
                this.hptext.gameObject.GetComponent<Text>().text = HP.ToString();

            }
        }
    
}
