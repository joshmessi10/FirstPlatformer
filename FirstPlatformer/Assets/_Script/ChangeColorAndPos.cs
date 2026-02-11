using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorAndPos : MonoBehaviour
{
    public SpriteRenderer _renderer;

    // Start is called before the first frame update
    void Start()
    {
       _renderer = GetComponent<SpriteRenderer>(); 
       ChangeColor();
    }

    // Metodo para cambiar de color
    public void ChangeColor(){
        _renderer.color = Color.black;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
