using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swordanime : MonoBehaviour
{
    Animator swordani;
    // Start is called before the first frame update
    void Start()
    {
        swordani = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            swordani.SetTrigger("slash");
            Debug.Log("slash");

        }
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            swordani.SetTrigger("thrust");
        }
    }
}
