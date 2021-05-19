using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wolfdie : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Sword"))
        {
            Debug.Log("Triggered by sword");
            Object.Destroy(this.gameObject);
        }
    }
}
