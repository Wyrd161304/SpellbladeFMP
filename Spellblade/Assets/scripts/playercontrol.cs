using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontrol : MonoBehaviour
{
    Rigidbody m_Rigidbody;
    public float m_Thrust = 20f;
    private bool isGrounded = false;
    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        //movement (CHANGE TO WASD later)
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += transform.forward * 30 * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += (-transform.forward) * 24 * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //transform.position += Vector3.left * Time.deltaTime;
            transform.Rotate(0.0f, -1.0f, 0.0f, Space.World);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            //transform.position += Vector3.right * Time.deltaTime;
            transform.Rotate(0.0f, 1.0f, 0.0f, Space.World);
        }
        //jumping
        if (Input.GetKey(KeyCode.Space))
        {
            if (isGrounded)
            {
                m_Rigidbody.AddForce(transform.up * m_Thrust);
            }
        }
    }
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Floor"))
        {
            isGrounded = true;
        }
    }

    void OnCollisionExit(Collision other)
    {
        if (other.gameObject.CompareTag("Floor"))
        {
            isGrounded = false;
        }
    }
}
