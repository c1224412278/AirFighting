using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BulletBehavior : ScriptableObject
{
    public GameObject bulletPrefab;     //子彈的預製物件
    public float flySpeed;              //子彈飛行速度
    public bool isPenetrate;            //子彈是否會穿透
    public Vector3 bornOffestPosition;  //產生子彈時，所要產生的偏差位置

    public abstract void Init();
    public abstract void CreateBulletObject(GameObject controllerTarget , int bornCount);  //建立子彈物件方法
    public abstract void BulletMove();  //子彈移動的執行動作
}
