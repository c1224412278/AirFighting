using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 中繼站 - 事件註冊用
/// </summary>
public class MainGameHost : MonoBehaviour
{
    public static MainGameHost instance
    {
        get { return Instance; }
    }
    private static MainGameHost Instance;

    public delegate void commonRegistered();
    public delegate void commonRegistered_bool(bool isActive);
    public commonRegistered del_characterController;
    public commonRegistered_bool del_characterShoot;

    private void Awake()
    {
        MainGameHost.Instance = this;
    }
}
