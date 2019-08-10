using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    [SerializeField] private BulletBehavior bulletBehavior;

    public IEnumerator ShootingBullet(GameObject controllerTarget , int count , float shootIntervalTime)
    {
        while (true)
        {
            yield return new WaitForSeconds(shootIntervalTime);
            this.bulletBehavior.Init(controllerTarget);
            this.bulletBehavior.CreateBulletObject(count);
        }
    }
}
