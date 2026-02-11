using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorAndPos2 : MonoBehaviour
{
    //Change Color and Pos triangle
    public GameObject triangle;

    // Start is called before the first frame update
    void Start()
    {
       //_renderer = GetComponent<SpriteRenderer>(); 
       ChangeColor();
       ChangePos();
    }

    // Metodo para cambiar de color
    public void ChangeColor(){
        triangle.GetComponent<SpriteRenderer>().color = Color.yellow; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ChangePos(){
        transform.position = triangle.transform.position;
    }
}
