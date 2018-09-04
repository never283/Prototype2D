using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;



public class SkillMaster : MonoBehaviour
{






    public void Sword()
    {


    }


    public void ShockWave()
    {
        //実際のロジック
        //DOTWeenを使うと良いかもしれない。
        Vector3[] paths = new Vector3[] {
            new Vector3 (this.transform.position.x + 2f, this.transform.position.y - 0f, -0.3f),
            new Vector3 (this.transform.position.x + 4f, this.transform.position.y - 1.5f, -0.3f),
            new Vector3 (this.transform.position.x + 6f, this.transform.position.y - 0f, -0.3f),
            new Vector3 (this.transform.position.x + 8f, this.transform.position.y - 1.5f, -0.3f),
            new Vector3 (this.transform.position.x + 10f, this.transform.position.y - 0f, -0.3f),
            new Vector3 (this.transform.position.x + 12f, this.transform.position.y - 1.5f, -0.3f),
        };
        GameObject prefab = (GameObject)Resources.Load("Prefabs/Skill1");
        var go = Instantiate(prefab, this.transform.position, Quaternion.identity);
        Tweener tween = go.transform.DOPath(paths, 10.0f, PathType.CatmullRom);
        go.AddComponent<DamageSkill>();
        go.GetComponent<DamageSkill>().damage = 99;

    }
}