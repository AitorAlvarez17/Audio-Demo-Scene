using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{

    private Light mainLight;

    public float changeColorTime = 0.3f;
    private float changeColorTimer;

    // Start is called before the first frame update
    void Start()
    {
        mainLight = gameObject.GetComponent<Light>();
        changeColorTimer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(changeColorTimer < changeColorTime)
        {
            changeColorTimer += Time.deltaTime;
            return;
        }

        changeColorTimer = 0f;

        mainLight.color = new Color(Random.Range(0F, 1F), Random.Range(0, 1F), Random.Range(0, 1F));

    }
}
