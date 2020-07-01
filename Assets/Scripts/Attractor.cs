using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attractor : MonoBehaviour
{
    float x;
    float y;
    float z;
    bool attracted = true;

    void Update()
    {
        if(attracted)
        {
            transform.position = Vector3.Lerp(transform.position, new Vector3(10,10,10), 0.25f);
        }
        else
        {
            transform.position = new Vector3(x, y, z);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        attracted = false;
        x = transform.position.x;
        y = transform.position.y;
        z = transform.position.z;
    }
}
