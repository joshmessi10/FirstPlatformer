using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangingColorAndPos3 : MonoBehaviour
{
    public GameObject hexagon;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<SpriteRenderer>().color = Color.yellow; 
        ChangeColor();
        ChangePos();
        float x = hexagon.transform.position.x;
        float y = hexagon.transform.position.y;
        float z = hexagon.transform.position.z;
        Debug.Log(string.Format("La posición del diamante es {0}, {1}, {2} y su color es {3}", x, y, z, GetComponent<SpriteRenderer>().color ));
    }

    // Metodo para cambiar de color
    public void ChangeColor(){
        
        hexagon.GetComponent<SpriteRenderer>().color = Color.cyan; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ChangePos(){
        transform.position = hexagon.transform.position;
    }
}
