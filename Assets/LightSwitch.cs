using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : MonoBehaviour
{
    Light lightComponent;

    void Start()
    {
        lightComponent = GetComponent<Light>();
    }


    private void OnTriggerEnter(Collider other)
    {
        lightComponent.enabled = true;
    }
}
