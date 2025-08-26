using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotaTest : MonoBehaviour
{
    public Transform joint1Transform;  // ������ת��
    public Transform joint2Transform;  // �����ת��
    public Transform joint3Transform;  // С����ת��
    public Transform joint4Transform;  // ĩ����ת��

    [Header("��ǰ�ؽڽǶ�")]
    public float joint1 = 0f;
    public float joint2 = 0f;
    public float joint3 = 0f;
    public float joint4 = 0f;
    // Start is called before the first frame update
    void Start()
    {
        joint1Transform.localRotation = Quaternion.Euler(90, 225 - joint1, -90); // ����ģ�������
        joint2Transform.localRotation = Quaternion.Euler(40 - joint2, 0, -90);
        joint3Transform.localRotation = Quaternion.Euler(0, -15 - joint3 + joint2, 0);
        joint4Transform.localRotation = Quaternion.Euler(0, 0, joint4);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
