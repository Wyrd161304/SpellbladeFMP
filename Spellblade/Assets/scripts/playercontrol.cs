using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontrol : MonoBehaviour
{
    Rigidbody rb;
    public Animator anim;

    public float m_Thrust = 20f;
    private bool isGrounded = false;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        anim = gameObject.GetComponent<Animator>();
    }

    void Update()
    {
        //movement (CHANGE TO WASD later)
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += transform.right * 30 * Time.deltaTime;
            anim.SetBool("isrunning", true);
        }
        else
        {
            anim.SetBool("isrunning", false);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += (-transform.right) * 24 * Time.deltaTime;
            anim.SetBool("isrunning", true);
        }
        else
        {
            anim.SetBool("isrunning", false);
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
                rb.AddForce(transform.up * m_Thrust);
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
