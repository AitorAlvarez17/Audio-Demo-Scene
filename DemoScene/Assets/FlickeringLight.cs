using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlickeringLight : MonoBehaviour
{

    private float flickerLightSpeed = 0.2f;
    private float flickerDarkSpeed = 0.1f;
    private float flickerLightTimer;
    private float flickerDarkTimer;


    private Light mainLight;

    // Start is called before the first frame update
    void Start()
    {
        mainLight = gameObject.GetComponent<Light>();
        flickerLightTimer = 0;
        flickerDarkTimer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(mainLight.enabled)
        {
            if(flickerLightTimer < flickerLightSpeed)
            {
                flickerLightTimer += Time.deltaTime;
                return;
            }
            flickerLightTimer = 0f;

            if (Random.Range(0f, 1f) >= 0.4f)
                mainLight.enabled = false;
            else
                mainLight.enabled = true;
        } else
        {
            if (flickerDarkTimer < flickerDarkSpeed)
            {
                flickerDarkTimer += Time.deltaTime;
                return;
            }
            flickerDarkTimer = 0f;

            if (Random.Range(0f, 1f) >= 0.4f)
                mainLight.enabled = true;
            else
                mainLight.enabled = false;
        }
    }
}
