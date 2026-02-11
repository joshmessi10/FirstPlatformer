using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hipotenusa : MonoBehaviour
{
    public int a;
    public int b;
    private double _result;
    // Start is called before the first frame update
    void Start()
    {
        string name = "hipotenusa";
        CalcularHipotenusa();
        Debug.Log(string.Format("La {0} es: {1}", name, _result));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CalcularHipotenusa(){
        _result = Math.Sqrt(Math.Pow(a,2) + Math.Pow(b,2));
    }
}
