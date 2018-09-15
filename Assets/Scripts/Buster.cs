using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buster : MonoBehaviour {


    public GameObject HitPrefab; //当たり判定オブジェクトを取得
    public GameObject HitSerch;
    public EnemyController enemycontroller;//EnemyControllerを取得
   
    

    private void Start()
    {
        var enemyUnityChan = GameObject.Find("enemyUnityChan");
        enemycontroller = enemyUnityChan.GetComponent<EnemyController>();
        //EHp = enemycontroller.GetEnemyHp();　//EnemyControllerから敵ＨＰを取得
        　　//Debug.Log(EHp);
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        { //スペースを押すと撃つ


            GameObject HitSerch = Instantiate(HitPrefab, this.transform.position, Quaternion.identity) as GameObject;
            Debug.Log("撃った");
            
        }


    }

   

    
}


	


