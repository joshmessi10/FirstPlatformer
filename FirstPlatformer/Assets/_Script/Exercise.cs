using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise : MonoBehaviour
{
    // Creacion de variables
    [Header("Numbers")]
    public int a;
    public int b;
    private int _result;
    // Start is called before the first frame update
    void Start()
    {
        AddNumber();
    }

    public void AddNumber(){
        //Metodo para la suma
        _result = a+b;
        Debug.Log("El resultado es: "+ _result);
        Debug.Log(string.Format("Este es el resultado: {0}", _result));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
