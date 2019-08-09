using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BulletBehavior : ScriptableObject
{
    public GameObject bulletPrefab;     //子彈的預製物件
    public float flySpeed;              //子彈飛行速度
    public bool isPenetrate;            //子彈是否會穿透

    public abstract void bulletMove();  //子彈移動的執行動作
}
