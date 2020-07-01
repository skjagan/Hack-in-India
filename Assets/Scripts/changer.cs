using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changer : MonoBehaviour
{
    GameObject[] childs;
    int i;
    GameObject previous;

    private void Start()
    {
        childs = new GameObject[transform.childCount];
        for (i = 0; i < transform.childCount; i++)
        {
            childs[i] = transform.GetChild(i).gameObject;
        }
        foreach (GameObject child in childs)
        {
            child.SetActive(false);
        }
        childs[0].SetActive(true);
        previous = childs[0];
        i = 0;
    }

    public void Actuator()
    {
        previous.SetActive(false);
        if (i == transform.childCount - 1)
        {
            i = 0;
        }
        else
        {
            i++;
        }
        childs[i].SetActive(true);
        previous = childs[i];
    }
}
