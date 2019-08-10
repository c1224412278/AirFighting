using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    [SerializeField] private BulletBehavior bulletBehavior;

    private void Start()
    {

    }

    public IEnumerator ShootingBullet(GameObject controllerTarget , int count , float shootIntervalTime)
    {
        this.bulletBehavior.Init();

        while (true)
        {
            yield return new WaitForSeconds(shootIntervalTime);    
            this.bulletBehavior.CreateBulletObject(controllerTarget , count);
        }
    }
}
