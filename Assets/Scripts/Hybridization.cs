using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hybridization : MonoBehaviour
{
    Vector3 pos;
    float speed = 10;
    float x;
    public int shellNum;
    TrailRenderer trailRenderer;


    void Start()
    {
        pos = transform.localPosition;
        trailRenderer = GetComponent<TrailRenderer>();
        x = UnityEngine.Random.Range(-4.0f, 4.0f);
    }

    void Update()
    {
        CalculatingShellNumber();
        float X = shellNum* Mathf.Cos(speed * Time.time) * Mathf.Cos(x * speed * Time.time);
        float Y = shellNum* Mathf.Sin(speed * Time.time) * Mathf.Cos(x * speed * Time.time);
        float Z = shellNum* Mathf.Sin(x * speed * Time.time);
        transform.localPosition = new Vector3(pos.x + X, pos.y + Y, pos.z + Z);
    }

    private void CalculatingShellNumber()
    {
        if (transform.parent.name == "K shell")
        {
            shellNum = 1;
            trailRenderer.startColor = new Color(0.9339623f, 0.3278928f, 0.1365699f);
            trailRenderer.endColor = Color.white;
            trailRenderer.widthMultiplier = 0.2f;
        }
        else if (transform.parent.name == "L shell")
        {
            shellNum = 2;
            trailRenderer.startColor = new Color(0.6352941f, 0.9254902f, 0.1254902f);
            trailRenderer.endColor = Color.white;
            trailRenderer.widthMultiplier = 0.1f;
        }
        else if (transform.parent.name == "M shell")
        {
            shellNum = 3;
            trailRenderer.startColor = new Color(0.1372549f, 0.4228581f, 0.9333333f);
            trailRenderer.endColor = Color.white;
            trailRenderer.widthMultiplier = 0.1f;
        }
    }
}
