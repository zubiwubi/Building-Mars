using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button1 : MonoBehaviour
{
    public Light Lamp;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
            Lamp.intensity = 130000;
    }
}
