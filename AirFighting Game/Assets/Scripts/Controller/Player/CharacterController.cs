using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    [SerializeField] private float minX_Value;
    [SerializeField] private float maxX_Value;
    [SerializeField] private float minY_Value;
    [SerializeField] private float maxY_Value;
    [SerializeField] private Rigidbody2D rigidbody2D;
    [SerializeField] private PlayerData playerData;
    [SerializeField] private BulletController bulletController;

    private void OnEnable()
    {
        this.RegisteredEvent();
    }
    private void Start()
    {
        
    }
    //開始遊戲 - 事件註冊
    private void RegisteredEvent()
    {
        MainGameHost.instance.del_characterController += MoveController;
    }
    //角色移動控制
    private void MoveController()
    {
        Vector2 movePosition = Vector2.zero;
        Vector2 inputPosition = new Vector2(Input.GetAxisRaw("Horizontal") , Input.GetAxisRaw("Vertical"));
        if (inputPosition.sqrMagnitude >= 0.01f)
        {
            movePosition = inputPosition.normalized * playerData.currectMoveSpeed * Time.deltaTime;
        }

        this.rigidbody2D.velocity = movePosition;
        this.transform.position = new Vector2(Mathf.Clamp(this.transform.position.x, this.minX_Value, this.maxX_Value),
                                                Mathf.Clamp(this.transform.position.y, this.minY_Value, this.maxY_Value));
    }
}
