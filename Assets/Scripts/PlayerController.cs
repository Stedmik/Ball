using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;

    Rigidbody rb;
    
    void Start()    //<- выполняется один раз во время запуска
    {
        rb = GetComponent<Rigidbody>();
    }

    
    void Update() //<- выполняется каждый кадр(для чайников: если 24к/c то выполняется 24 р. и т.д.)
    {
        float moveX = Input.GetAxis("Horizontal");      //движение по горизонтали
        float moveZ = Input.GetAxis("Vertical");        //движение по вертикали

        //print(moveX.ToString() + " " + moveZ.ToString());   //вывод в консоль, хз зачем 

        Vector3 move = new Vector3(moveX * speed, rb.velocity.y, moveZ * speed);    //вектор движения 

        

        rb.velocity = move;
        //velocit = направление
    }
}
