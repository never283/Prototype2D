using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardData : ScriptableObject
{
    public Sprite image; //画像
    public int power;　//攻撃力
    public string text;　//説明文
    public string code;　//種類
    public string skillcode;　//系統
    public int Rare;　//レア度
    public int Attribute;　//属性
    public int Range; //攻撃範囲
}

