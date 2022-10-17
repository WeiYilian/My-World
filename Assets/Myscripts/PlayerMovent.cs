using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovent : MonoBehaviour
{
    #region 第四版
   


    void Start()
    {
       

    }
    private void FixedUpdate()
    {
        
    }



    public void PlayerMove()
    {
       
    }
    #endregion

    #region 角色控制器                                         第三版
    //public Transform FollowedComera;
    //private Transform pointBottom;
    //public float runSpeed = 3f;
    //public float walkSpeed = 1.5f;
    //public float rotateSpeed = 6f;
    //public float moveSpeed;
    //public float jumpForce;
    //public float margin = 0.1f;
    //public float gravity = 20;

    //private CharacterController character;
    //private Animator anim;

    //private void Start()
    //{
    //    anim = GetComponent<Animator>();
    //    character = GetComponent<CharacterController>();
    //}

    ///// <summary>
    ///// 通过射线检测主角是否落在地面或物体上
    ///// </summary>
    //bool isGrounded()
    //{
    //    //根据需要可以更改margin的值
    //    return Physics.Raycast(transform.position, -Vector3.up, margin);
    //}

    //private void Update()
    //{
    //    AnimatorStateInfo animatorStateInfo = anim.GetCurrentAnimatorStateInfo(0);

    //    Vector3 dir = Vector3.zero;//创建移动方向向量

    //    float horizontal = Input.GetAxis("Horizontal");
    //    float vertical = Input.GetAxis("Vertical");

    //    dir.y -= gravity * Time.deltaTime;
    //    character.Move(dir * Time.deltaTime);

    //    //使玩家的方向与摄像机的方向同步
    //    if (horizontal != 0 || vertical != 0)
    //    {
    //        if (vertical > 0)
    //        {
    //            dir = new Vector3(FollowedComera.transform.forward.x, 0, FollowedComera.transform.forward.z);
    //            Quaternion newRotation = Quaternion.LookRotation(dir);
    //            transform.rotation = Quaternion.RotateTowards(transform.rotation, newRotation, 100);
    //        }
    //        if (vertical < 0)
    //        {
    //            dir = new Vector3(-FollowedComera.transform.forward.x, 0, -FollowedComera.transform.forward.z);
    //            Quaternion newRotation = Quaternion.LookRotation(dir);
    //            transform.rotation = Quaternion.RotateTowards(transform.rotation, newRotation, 100);
    //        }
    //        if (horizontal > 0)
    //        {
    //            dir = new Vector3(FollowedComera.transform.right.x, 0, FollowedComera.transform.right.z);
    //            Quaternion newRotation = Quaternion.LookRotation(dir);
    //            transform.rotation = Quaternion.RotateTowards(transform.rotation, newRotation, 100);
    //        }
    //        if (horizontal < 0)
    //        {
    //            dir = new Vector3(-FollowedComera.transform.right.x, 0, -FollowedComera.transform.right.z);
    //            Quaternion newRotation = Quaternion.LookRotation(dir);
    //            transform.rotation = Quaternion.RotateTowards(transform.rotation, newRotation, 100);
    //        }
    //        anim.SetFloat("Speed", Mathf.Abs(horizontal) + Mathf.Abs(vertical), 0.01f, Time.deltaTime);
    //        character.Move(dir * moveSpeed);
    //    }

    //    if (character.isGrounded)
    //    {
    //        if (Input.GetMouseButtonDown(0))
    //        {
    //            anim.SetTrigger("Attack");
    //            //检测以自身半径为2.5的球形范围内是否有层级为敌人的游戏物体，有就存入数组中，并依次实现敌人的死亡动画；没有就直接返回
    //            Collider[] colliders = Physics.OverlapSphere(transform.position, 2.5f, LayerMask.GetMask("Enemy"));
    //            if (colliders.Length <= 0) return;
    //            for (int i = 0; i < colliders.Length; i++)
    //            {
    //                Animator enemyAnim = colliders[i].gameObject.GetComponent<Animator>();
    //                enemyAnim.SetTrigger("Knockback");
    //            }
    //        }
    //        else if (Input.GetKeyDown(KeyCode.Space))
    //        {
    //            anim.SetTrigger("Jump");
    //            dir.y = jumpForce;
    //        }
    //    }
    //}

    #endregion

    #region 简单移动奔跑（使用刚体和碰撞器）                   第二版
    //public float runSpeed = 3f;
    //public float walkSpeed = 1.5f;
    //public float rotateSpeed = 6f;
    //private float moveSpeed;
    //private bool isRun;

    //private Rigidbody m_rigidbody;
    //private Animator anim;


    //void Start()
    //{
    //    m_rigidbody = GetComponent<Rigidbody>();
    //    anim = GetComponent<Animator>();

    //}
    //private void FixedUpdate()
    //{
    //    PlayerMove();
    //}



    //public void PlayerMove()
    //{
    //    float horizontal = Input.GetAxis("Horizontal");//获取水平轴
    //    float vertical = Input.GetAxis("Vertical");//获取垂直轴
    //    if (Input.GetKey(KeyCode.LeftShift))
    //    {
    //        isRun = true;
    //    }
    //    moveSpeed = isRun ? runSpeed : walkSpeed;
    //    Vector3 dir = new Vector3(horizontal, 0, vertical);//创建方向向量
    //    if (dir != Vector3.zero)
    //    {
    //        //transform.rotation = Quaternion.LookRotation(dir);//朝向dir向量方向
    //        Quaternion targetRot = Quaternion.FromToRotation(transform.forward, dir.normalized) * transform.rotation;//计算目标旋转值
    //        transform.rotation = Quaternion.Slerp(transform.rotation, targetRot, rotateSpeed * Time.deltaTime);//顺滑转向
    //        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);//移动
    //    }
    //    anim.SetFloat("Speed", dir.magnitude);//Vector3.magnitude是取向量长度
    //    anim.SetBool("isRun", isRun);
    //    isRun = false;
    //}
    #endregion

    #region FPS移动(无转向，需鼠标控制方向                     第一版
    //public float runSpeed = 3f;
    //public float walkSpeed = 1.5f;
    //private Vector3 m_Move;

    //private Rigidbody m_rigidbody;
    //private Animator anim;

    //void Start()
    //{
    //    m_rigidbody = GetComponent<Rigidbody>();
    //    anim = GetComponentInChildren<Animator>();

    //}
    //private void FixedUpdate()
    //{
    //    PlayerMove();
    //}

    //public void PlayerMove()
    //{
    //    float h = Input.GetAxis("Horizontal");
    //    float v = Input.GetAxis("Vertical");

    //    if (Input.GetKey(KeyCode.LeftShift))
    //    {
    //        m_Move = v * Vector3.forward + h * Vector3.right;
    //        m_rigidbody.velocity = new Vector3(h, 0, v) * runSpeed;
    //    }
    //    else
    //    {
    //        m_Move = (v * Vector3.forward + h * Vector3.right) * 0.5f;
    //        m_rigidbody.velocity = new Vector3(h, 0, v) * walkSpeed;
    //    }
    //    UpdateAnimator(m_Move);
    //}

    //void UpdateAnimator(Vector3 move)
    //{
    //    anim.SetFloat("Walk", move.z, 0.1f, Time.deltaTime);
    //    anim.SetFloat("Turn", move.x, 0.1f, Time.deltaTime);
    //}
    #endregion

}
