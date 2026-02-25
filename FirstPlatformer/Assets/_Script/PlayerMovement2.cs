using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement2 : MonoBehaviour
{
    private NewInput _newInput;
    public float speed;
    private Rigidbody2D _rb;
    // Start is called before the first frame update
    void Start()
    {
        _newInput = GetComponent<NewInput>();
        _rb = GetComponent<Rigidbody2D>();
    }

    // FixedUpdate -> Fisicas
    void FixedUpdate()
    {
        Movement();
    }

    public void Movement(){
        //transform.Translate(Vector3.right * speed * _newInput.inputX * Time.deltaTime);
        _rb.velocity = new Vector2(speed * _newInput.inputX, _rb.velocity.y);
    }

}
