using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    Rigidbody rigid;
    public float speed = 3;
    
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");

        Vector3 input = new Vector3(horizontal, 0, vertical);
        rigid.AddForce(input * speed);
    }
}
