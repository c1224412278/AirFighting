using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "DataMenu/Bullet/Create/GeneralBullet")]
public class GeneralBullet : BulletBehavior
{
    private Vector3 controllerPosition;
    private GameObject controllerTarget;
    private List<GameObject> bulletObjects;

    public override void Init(GameObject controllerTarget)
    {
        if (this.bulletObjects == null)
            this.bulletObjects = new List<GameObject>();
        else
            this.bulletObjects.Clear();

        this.controllerTarget = controllerTarget;
        this.controllerPosition = controllerTarget.transform.position;
    }

    public override void CreateBulletObject(int bornCount)
    {
        for (int i = 0; i < bornCount; i ++)
        {
            GameObject newBullet = Instantiate(this.bulletPrefab);
            this.bulletObjects.Add(newBullet);
        }

        switch (bornCount)
        {
            case 1:
                this.bulletObjects[0].transform.position = (this.controllerPosition + this.bornOffestPosition);
                break;

            case 2:

                break;
        }
    }

    public override void BulletMove()
    {
        
    }
}
