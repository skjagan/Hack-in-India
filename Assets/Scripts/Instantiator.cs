using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Instantiator : MonoBehaviour
{
    [SerializeField] GameObject proton;
    [SerializeField] GameObject neutron;
    [SerializeField] GameObject electron;
    [SerializeField] Transform nucleusParent;
    [SerializeField] Transform KshellParent;
    [SerializeField] Transform LshellParent;
    [SerializeField] Transform MshellParent;
    [SerializeField] InputField zValue;
    [Range(1,20)] public int Z = 1;
    int n;
    int p;
    int e;
    float xPos;
    float yPos;
    float zPos;
    textUpdater TextUpdater;

    private void Start()
    {
        TextUpdater = GetComponent<textUpdater>();
    }

    public void UpdateZValue()
    {
        transform.localScale = new Vector3(1, 1, 1);
        Z = int.Parse(zValue.text);
        DestroyPreviousSubAtomicParticles();
        CalculatingSubAtomicParticles();
        InstantiateNeutron();
        InstantiateProton();
        InstantiateElectron();
        TextUpdater.UpdateText(Z);
        transform.localScale = new Vector3(.005f, .005f, .005f);
    }

    private void DestroyPreviousSubAtomicParticles()
    {
        Hybridization[] eles = FindObjectsOfType<Hybridization>();
        foreach (Hybridization ele in eles)
        {
            Destroy(ele.gameObject);
        }
        Attractor[] nucs = FindObjectsOfType<Attractor>();
        foreach (Attractor nuc in nucs)
        {
            Destroy(nuc.gameObject);
        }
    }

    private void InstantiateNeutron()
    {
        int i;
        for (i=1;  i<=n; i++)
        {
            xPos = UnityEngine.Random.Range(-15, 15);
            yPos = UnityEngine.Random.Range(-15, 15);
            zPos = UnityEngine.Random.Range(-15, 15);
            GameObject neu = Instantiate(neutron, new Vector3(xPos, yPos, zPos), Quaternion.identity);
            neu.transform.SetParent(nucleusParent);
        }
    }

    private void InstantiateElectron()
    {
        int i;
        for (i = 1; i <= e; i++)
        {
            if (i <= 2)
            {
                GameObject ele = Instantiate(electron, new Vector3(0, 0, 0), Quaternion.identity);
                ele.transform.SetParent(KshellParent);
            }
            else if (i > 2 && i <= 10)
            {
                GameObject ele = Instantiate(electron, new Vector3(0, 0, 0), Quaternion.identity);
                ele.transform.SetParent(LshellParent);
            }
            else
            {
                GameObject ele = Instantiate(electron, new Vector3(0, 0, 0), Quaternion.identity);
                ele.transform.SetParent(MshellParent);
            }
        }
    }

    private void InstantiateProton()
    {
        int i;
        for (i = 1; i <= p; i++)
        {
            xPos = UnityEngine.Random.Range(-15, 15);
            yPos = UnityEngine.Random.Range(-15, 15);
            zPos = UnityEngine.Random.Range(-15, 15);
            GameObject pro = Instantiate(proton, new Vector3(xPos, yPos, zPos), Quaternion.identity);
            pro.transform.SetParent(nucleusParent);
        }
    }

    private void CalculatingSubAtomicParticles()
    {
        if (Z == 1) { p = 1; e = 1; n = 0; }
        else
        {
            p = Z;
            e = Z;
            n = Z;
        }
    }
}
