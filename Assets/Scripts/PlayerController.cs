using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;

    Rigidbody rb;
    
    void Start()    //<- ����������� ���� ��� �� ����� �������
    {
        rb = GetComponent<Rigidbody>();
    }

    
    void Update() //<- ����������� ������ ����(��� ��������: ���� 24�/c �� ����������� 24 �. � �.�.)
    {
        float moveX = Input.GetAxis("Horizontal");      //�������� �� �����������
        float moveZ = Input.GetAxis("Vertical");        //�������� �� ���������

        //print(moveX.ToString() + " " + moveZ.ToString());   //����� � �������, �� ����� 

        Vector3 move = new Vector3(moveX * speed, rb.velocity.y, moveZ * speed);    //������ �������� 

        

        rb.velocity = move;
        //velocit = �����������
    }
}
