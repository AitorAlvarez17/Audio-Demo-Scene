using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoliceColor : MonoBehaviour
{

    private Light mainLight;

    public float changeColorTime = 0.3f;
    private float changeColorTimer;

    public bool red;

    // Start is called before the first frame update
    void Start()
    {
        mainLight = gameObject.GetComponent<Light>();
        changeColorTimer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (changeColorTimer < changeColorTime)
        {
            changeColorTimer += Time.deltaTime;
            return;
        }

        changeColorTimer = 0f;

        if (red)
        {
            mainLight.color = Color.red;
            red = false;
        }
        else
        {
            mainLight.color = Color.blue;
            red = true;
        }
    }
}
