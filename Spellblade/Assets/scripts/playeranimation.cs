using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playeranimation : MonoBehaviour
{
    Animator bellaanime;
    // Start is called before the first frame update
    void Start()
    {
        bellaanime = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            bellaanime.SetBool("isrunning", true);
        }
        else
        {
            bellaanime.SetBool("isrunning", false);
        }

        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            bellaanime.SetBool("isrunningback", true);
        }
        else
        {
            bellaanime.SetBool("isrunningback", false);
        }

        if (Input.GetKey(KeyCode.Mouse0))
        {
            bellaanime.SetTrigger("slash");
        }
        if (Input.GetKey(KeyCode.Mouse1))
        {
            bellaanime.SetTrigger("thrust");
        }
    }
}
