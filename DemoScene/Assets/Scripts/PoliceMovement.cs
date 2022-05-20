using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoliceMovement : MonoBehaviour
{

    public List<Vector3> patrolPoints;


    public float speed = 10f;
    
    private int iterator;

    // Start is called before the first frame update
    void Start()
    {
        iterator = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (iterator < patrolPoints.Count)
        {
            transform.rotation = Quaternion.LookRotation(patrolPoints[iterator] - transform.position);
            transform.position = Vector3.MoveTowards(transform.position, patrolPoints[iterator], speed * Time.deltaTime);
            if (transform.position == patrolPoints[iterator])
            {
                iterator++;
            }
        }
        else
        {
            iterator = 0;
        }
    }
}
