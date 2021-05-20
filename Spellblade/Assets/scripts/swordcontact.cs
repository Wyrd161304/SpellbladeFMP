using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swordcontact : MonoBehaviour
{
    public GameObject enemycollide;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Enemy")
        {
            Debug.Log("Triggered by enemy");
        }
    }
}
