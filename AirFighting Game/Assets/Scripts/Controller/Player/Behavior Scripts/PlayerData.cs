using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "DataMenu/Player/Create")]
public class PlayerData : ScriptableObject
{
    public int maxHp;
    public int currectHp;
    public float maxMoveSpeed;
    public float minMoveSpeed;
    public float currectMoveSpeed;
    public float shootCDTime;
}