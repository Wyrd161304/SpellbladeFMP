using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthbar : MonoBehaviour
{
    public Slider slider;
    void Start()
    {
        
    }
    void Update()
    {
        slider.value = playerhealth.health;
    }
}
