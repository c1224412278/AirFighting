using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 遊戲主流程、 Update 流程
/// </summary>
public class GameExecute : MonoBehaviour
{
    private void Start()
    {
        if (MainGameHost.instance.del_characterShoot != null)
            MainGameHost.instance.del_characterShoot(true);
    }
    private void Update()
    {
        
    }
    private void LateUpdate()
    {
        
    }
    private void FixedUpdate()
    {
        if (MainGameHost.instance.del_characterController != null)
            MainGameHost.instance.del_characterController();
    }
}
