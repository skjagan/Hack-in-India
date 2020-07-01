using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class textUpdater : MonoBehaviour
{
    [SerializeField] TextMesh element;
    [SerializeField] TextMesh symbol;
    [SerializeField] TextMesh protonsNo;
    [SerializeField] TextMesh neutronsNo;
    [SerializeField] TextMesh electronsNo;
    [SerializeField] TextMesh K;
    [SerializeField] TextMesh L;
    [SerializeField] TextMesh M;
    [SerializeField] TextMesh valency;
    int Z;

    public void UpdateText(int value)
    {
        Z = value;
        updateElement();
        noOfSubAtoms();
        updateShells();
    }

    private void updateShells()
    {
        if (Z<=2)
        {
            K.text = Z.ToString();
            L.text = 0.ToString();
            M.text = 0.ToString();
        }
        else if (Z>=3 && Z<=20)
        {
            K.text = 2.ToString();
            M.text = 0.ToString();
            if (Z<=10)
            {
                L.text = (Z - 2).ToString();
            }
            else if (Z>=11)
            {
                L.text = 8.ToString();
                if (Z<=18)
                {
                    M.text = (Z - 10).ToString();
                }
                else if (Z>=19)
                {
                    M.text = 8.ToString();
                }
            }
        }
    }

    private void noOfSubAtoms()
    {
        protonsNo.text = Z.ToString();
        electronsNo.text = Z.ToString();
        if (Z==1) 
        { 
            neutronsNo.text = 0.ToString(); 
        }
        else if (Z == 3 || Z == 4 || Z == 5 || Z == 9 || Z == 11 || Z == 13 || Z == 15 || Z == 17 || Z == 19) 
        { 
            neutronsNo.text = (Z+1).ToString(); 
        }
        else if (Z == 18) 
        { 
            neutronsNo.text = 22.ToString(); 
        }
        else
        {
            neutronsNo.text = Z.ToString();
        }
    }

    private void updateElement()
    {
        if (Z==1)
        {
            element.text = "Hydrogen";
            symbol.text = "H";
            valency.text = 1.ToString();
        }
        else if (Z==2)
        {
            element.text = "Helium";
            symbol.text = "He";
            valency.text = 0.ToString();
        }
        else if (Z == 3)
        {
            element.text = "Lithium";
            symbol.text = "Li";
            valency.text = 1.ToString();
        }
        else if (Z == 4)
        {
            element.text = "Beryllium";
            symbol.text = "Be";
            valency.text = 2.ToString();
        }
        else if (Z == 5)
        {
            element.text = "Broron";
            symbol.text = "B";
            valency.text = 3.ToString();
        }
        else if (Z == 6)
        {
            element.text = "Carbon";
            symbol.text = "C";
            valency.text = 4.ToString();
        }
        else if (Z == 7)
        {
            element.text = "Nitrogen";
            symbol.text = "N";
            valency.text = 3.ToString();
        }
        else if (Z == 8)
        {
            element.text = "Oxygen";
            symbol.text = "O";
            valency.text = 2.ToString();
        }
        else if (Z == 9)
        {
            element.text = "Fluorine";
            symbol.text = "F";
            valency.text = 1.ToString();
        }
        else if (Z == 10)
        {
            element.text = "Neon";
            symbol.text = "Ne";
            valency.text = 0.ToString();
        }
        else if (Z == 11)
        {
            element.text = "Sodium";
            symbol.text = "Na";
            valency.text = 1.ToString();
        }
        else if (Z == 12)
        {
            element.text = "Magnesium";
            symbol.text = "Mg";
            valency.text = 2.ToString();
        }
        else if (Z == 13)
        {
            element.text = "Aluminium";
            symbol.text = "Al";
            valency.text = 3.ToString();
        }
        else if (Z == 14)
        {
            element.text = "Silicon";
            symbol.text = "Si";
            valency.text = 4.ToString();
        }
        else if (Z == 15)
        {
            element.text = "Phosphorus";
            symbol.text = "P";
            valency.text = 3.ToString();
        }
        else if (Z == 16)
        {
            element.text = "Sulphur";
            symbol.text = "S";
            valency.text = 2.ToString();
        }
        else if (Z == 17)
        {
            element.text = "Chlorine";
            symbol.text = "Cl";
            valency.text = 1.ToString();
        }
        else if (Z == 18)
        {
            element.text = "Argon";
            symbol.text = "Ar";
            valency.text = 0.ToString();
        }
        else if (Z == 19)
        {
            element.text = "Potassium";
            symbol.text = "K";
            valency.text = 1.ToString();
        }
        else if (Z == 20)
        {
            element.text = "Calcium";
            symbol.text = "Ca";
            valency.text = 2.ToString();
        }
    }
}
