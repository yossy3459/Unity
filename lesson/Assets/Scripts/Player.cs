using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
    public Vector3 moveDirection;
    public CharacterController cc;
    public float gravity = 1, jumpSpeed = 100, zMoveSpeed = 5, rotateSpeed = 1;

    float nowJumpSpeed = 0;

	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame 毎フレーム実行
	void Update ()
    {
        ZMove();
        Rotate();
        YMove();

        cc.Move(moveDirection / 60);
        moveDirection = Vector3.zero;
	}

    void ZMove()
    {
        if (Input.GetButton("Vertical"))
        {
            moveDirection = transform.forward * Input.GetAxisRaw("Vertical") * zMoveSpeed;

        }
    }

    void Rotate()
    {
        if (Input.GetButton("Horizontal"))
        {
            transform.Rotate(0, Input.GetAxisRaw("Horizontal") * rotateSpeed, 0);
        }
    }

    void YMove()
    {
        if (cc.isGrounded) // 接地している = ジャンプさせる
        {
            if (Input.GetButton("Fire1"))
            {
                nowJumpSpeed = jumpSpeed;
                moveDirection.y = nowJumpSpeed;

            }
        }
        else // 接地していない = 落下させる
        {
            nowJumpSpeed += gravity / 60;
            moveDirection.y = nowJumpSpeed;
        }
    }
}

