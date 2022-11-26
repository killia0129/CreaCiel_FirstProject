using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Rigidbody rb;
    public float Up = 10.0f;
    public float Down = 10.0f;
    public float Right = 10.0f;
    public float Left = 10.0f;
    public float Forword = 20.0f;
    void Start()
    {
        // Rigidbody�R���|�[�l���g���擾���� 
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        rb.velocity = transform.forward * Forword;

        //rb.velocity = transform.right * Forword;
    }
    void FixedUpdate()
    {
        
        Debug.Log(rb.velocity.magnitude);
        // W�L�[�őO�ɐi�� 
        if (Input.GetKey(KeyCode.W))
        {
            rb.velocity = new Vector3(0, Up, 0);
        }
        // S�L�[�Ō��ɐi�� 
        if (Input.GetKey(KeyCode.S))
        {
            rb.velocity = new Vector3(0, -Down, 0);
        }
        //D�L�[�ŉE���s�ړ�
        if (Input.GetKey(KeyCode.D))
        {
            //rb.MovePosition(transform.position - transform.up * 1.0f * Time.deltaTime); 
            rb.velocity = transform.right * Right;
        }
        // A�L�[�ō����s�ړ� 
        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = transform.right * -Left;
        }
    }
}
