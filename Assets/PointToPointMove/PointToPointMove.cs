using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointToPointMove : MonoBehaviour
{
    // 移動させるGameObject
    public GameObject m_movingObject;

    // 移動先地点のGameObject
    public GameObject[] m_movePoints;

    public int m_maxX = 2;
    public int m_maxY = 2;
    public string m_prefix = "Panel";
    int m_posX = 1;
    int m_posY = 1;

    void Start()
    {
    }

    void Update()
    {
        // 上カーソル押下時
        if (Input.GetKeyDown(KeyCode.UpArrow))
            m_posY = m_posY >= m_maxY - 1 ? m_maxY : m_posY + 1; // m_posYが最大値を超えないようにしている。
        // 下カーソル押下時
        if (Input.GetKeyDown(KeyCode.DownArrow))
            m_posY = m_posY <= 0 ? 0 : m_posY - 1;  // m_posYが最小値より小さくならないようにしている。
        // 右カーソル押下時
        if (Input.GetKeyDown(KeyCode.RightArrow))
            m_posX = m_posX >= m_maxX - 1 ? m_maxX : m_posX + 1;    // m_posXが最大値を超えないようにしている。
        if (Input.GetKeyDown(KeyCode.LeftArrow))
            m_posX = m_posX <= 0 ? 0 : m_posX - 1;  // m_posXが最小値より小さくならないようにしている。

        // "Point" + m_posX + m_posY でFindで探すGameObjectの名前を決めている
        string movePointName = m_prefix + m_posX.ToString() + m_posY.ToString();

        // 上記で決めた名前のGameObjectを取得
        GameObject movePoint = GameObject.Find(movePointName);

        if (movePoint)
            // 対象のGameObjectを上記でmovePointの座標へ移動
            m_movingObject.transform.position = movePoint.transform.position;
    }
}


