using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public float speed = 1.0f;
    public Vector3 direction;


    void Start()
    {
        // transform.position : ���� ������Ʈ�� ���� ��ġ�� �ǹ��մϴ�.
        Debug.Log(transform.position);
    }
    void Update()
    {
        direction.x = Input.GetAxisRaw("Horizontal");
        direction.z = Input.GetAxisRaw("Vertical");

        //������ ����ȭ 
        direction.Normalize();  

        //time.deltaTime : ������ �� �̵� ������ �ð� ����

        transform.position = transform.position + direction * speed * Time.deltaTime;
    }
}
