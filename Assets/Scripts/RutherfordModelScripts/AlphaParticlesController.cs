using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlphaParticlesController : MonoBehaviour
{
    GameObject goldFoil;
    GameObject m1;
    GameObject m2;
    float x = 0;
    float z = 1.0f;


    void Update()
    {
        m1 = FindObjectOfType<AlphaParticlesInstantiater>().m1;
        m2 = FindObjectOfType<AlphaParticlesInstantiater>().m2;
        transform.position = new Vector3(transform.position.x + x*Time.deltaTime, transform.position.y, transform.position.z + z*Time.deltaTime);
        if (m1.activeInHierarchy==true)
        {
            goldFoil = GameObject.FindGameObjectWithTag("goldFoil");
            if (transform.position.z >= goldFoil.transform.position.z)
            {
                Collison();
            }
        }
        else if (m2.activeInHierarchy == true)
        {
            Zoomed();
        }
        else { return; }
    }

    private void Zoomed()
    {
        if (this.transform.position.z >= 2.04f && this.transform.position.z <= 2.308f)
        {
            if (this.transform.position.x >= -0.58f || this.transform.position.x <= -1.4f)
            {
                z = -1.0f;
            }
            else if (this.transform.position.x >= -0.64f)
            {
                x = -0.5f;
            }
            else if (this.transform.position.x <= -1.34f)
            {
                x = 0.5f;
            }
            ColourChanger();
            Destroy(gameObject, 4f);
        }
        if (this.transform.position.z >= 2.83f && this.transform.position.z <= 3.036f)
        {
            if (this.transform.position.x <= -0.963f && this.transform.position.x >= -1.025f)
            {
                z = -1.0f;
            }
            else if (this.transform.position.x <= -0.917f && this.transform.position.x >= -0.963f)
            {
                x = 0.5f;
            }
            else if (this.transform.position.x >= -1.071f && this.transform.position.x <= -1.025f)
            {
                x = -0.5f;
            }
            ColourChanger();
            Destroy(gameObject, 2f);
        }
    }

    private void ColourChanger()
    {
        if (x != 0)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.blue;
        }
        else if (z == -1.0f)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.red;
        }
        else
        {
            gameObject.GetComponent<Renderer>().material.color = Color.green;
        }
    }

    void Collison()
    {
        if (this.gameObject.tag == "Deflector")
        {
            x = 0.5f;
            gameObject.GetComponent<Renderer>().material.color = Color.blue;
        }
        else if (this.gameObject.tag == "Rebounder")
        {
            z = -1.0f;
            gameObject.GetComponent<Renderer>().material.color = Color.red;
        }
        else
        {
            gameObject.GetComponent<Renderer>().material.color = Color.green;
        }
        Destroy(gameObject, 2);
    }
}
