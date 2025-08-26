using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotaTest : MonoBehaviour
{
    public Transform joint1Transform;  // 底座旋转轴
    public Transform joint2Transform;  // 大臂旋转轴
    public Transform joint3Transform;  // 小臂旋转轴
    public Transform joint4Transform;  // 末端旋转轴

    [Header("当前关节角度")]
    public float joint1 = 0f;
    public float joint2 = 0f;
    public float joint3 = 0f;
    public float joint4 = 0f;
    // Start is called before the first frame update
    void Start()
    {
        joint1Transform.localRotation = Quaternion.Euler(90, 225 - joint1, -90); // 根据模型轴调整
        joint2Transform.localRotation = Quaternion.Euler(40 - joint2, 0, -90);
        joint3Transform.localRotation = Quaternion.Euler(0, -15 - joint3 + joint2, 0);
        joint4Transform.localRotation = Quaternion.Euler(0, 0, joint4);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
