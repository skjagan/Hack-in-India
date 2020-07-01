using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlphaParticlesInstantiater : MonoBehaviour
{
    [SerializeField] GameObject alphaParticle;
    public GameObject m1;
    public GameObject m2;
    float x;
    float y;
    int i = 0;
    int n = 1;
    int o = 1;

    void Start()
    {
        StartCoroutine(ByPassers());
    }

    private void Update()
    {
        if (m1.activeInHierarchy == true)
        {
            x = Random.Range(-1.025f, -0.5f);
            y = Random.Range(1.05f, 1.5f);
        }
        else if (m2.activeInHierarchy == true)
        {
            x = Random.Range(-1.425f, -0.561f);
            y = 1.25f;
        }
    }

    IEnumerator ByPassers()
    {
        for (i = 0; i < 70; i++)
        {
            Instantiate(alphaParticle, new Vector3(x, y, -3.3f), Quaternion.identity);
            if (i == 3*n)
            {
                alphaParticle.tag = "Deflector";
                n++;
            }
            else if (i == 7*o)
            {
                alphaParticle.tag = "Rebounder";
                o++;
            }
            else
            {
                alphaParticle.tag = "ByPasser";
            }
            yield return new WaitForSeconds(1f);
        }
    }
    public void ZoomViewer()
    {
        if (m1.activeInHierarchy)
        {
            m1.SetActive(false);
            m2.SetActive(true);
        }
        else if (m2.activeInHierarchy)
        {
            m2.SetActive(false);
            m1.SetActive(true);
        }
    }

}
