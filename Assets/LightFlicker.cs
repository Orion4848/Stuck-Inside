using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class LightFlicker : MonoBehaviour
{
    public Light2D light2D;
   // public float intensityChangeRate = 0.05f;

   // private bool increasingIntensity = true;

    private void Start()
    {
      
            
            light2D = GetComponent<Light2D>();
     
    }

    private void Update()
    {
        light2D.volumeIntensity = Random.Range(0.03f, 0.05f);
        light2D.intensity = Random.Range(1.3f, 1.8f);


    }
}

