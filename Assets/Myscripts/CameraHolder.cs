using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraHolder : MonoBehaviour
{
    #region 相机跟随移动
    //public float sensitivityMouse = 2f;
    //public Transform target;
    ////观察距离
    //public float Distance = 5f;

    ////旋转角度
    //private float mouseX;
    //private float mouseY;
    ////角度限制
    //private float MinLimity = -20;
    //private float MaxLimity = 20;
    ////是否启用差值
    //public bool isNeedDomping = true;
    ////速度
    //public float Damping = 2.5f;

    //private void LateUpdate()
    //{
    //    //获取鼠标输入
    //    mouseX += Input.GetAxis("Mouse X") * sensitivityMouse;
    //    mouseY -= Input.GetAxis("Mouse Y") * sensitivityMouse;
    //    //限制范围
    //    mouseY = ClampAngle(mouseY, MinLimity, MaxLimity);

    //    //重新计算位置和角度
    //    Quaternion mouseRotation = Quaternion.Euler(mouseY, mouseX, 0);
    //    Vector3 mousePosition = mouseRotation * new Vector3(0.0f, 2.0f, -Distance) + target.position;

    //    //设置相机的角度和位置
    //    if (isNeedDomping)
    //    {
    //        //球形插值
    //        transform.rotation = Quaternion.Slerp(transform.rotation, mouseRotation, Time.deltaTime * Damping);
    //        //线性插值
    //        transform.position = Vector3.Lerp(transform.position, mousePosition, Time.deltaTime * Damping);
    //    }
    //    else
    //    {
    //        transform.position = mousePosition;
    //        transform.rotation = mouseRotation;
    //    }
    //}
    ///// <summary>
    ///// 计算范围限制
    ///// </summary>
    //private float ClampAngle(float angler, float min, float max)
    //{
    //    if (angler < -360) angler += 360;
    //    if (angler > 360) angler -= 360;
    //    return Mathf.Clamp(angler, min, max);
    //}

    #endregion

    #region 2.5D可用摄像机跟随
    //public float distanceAway = 3f;
    //public float distanceUp = 3f;
    //public float smooth = 2f;

    //private Vector3 m_TargetPosition; // 摄像机需要移动到的位置

    //private Transform follow;

    //void Start()
    //{

    //    follow = GameObject.FindWithTag("Player").transform;
    //}

    //void LateUpdate()
    //{
    //    // 计算摄像机需要移动到的位置
    //    m_TargetPosition = follow.position + Vector3.up * distanceUp - follow.forward * distanceAway;
    //    // 使摄像机平滑移动
    //    transform.position = Vector3.Lerp(transform.position, m_TargetPosition, Time.deltaTime * smooth);
    //    // 使摄像机一直面对玩家
    //    transform.LookAt(follow);

    //}
    #endregion
}
