using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement2 : MonoBehaviour
{
    private NewInput _newInput;
    public float speed;
    private Rigidbody2D _rb;
    public Animator _animator;
    private SpriteRenderer _spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        PlayerStats.score = 0;
        _animator = GetComponent<Animator>();
        _newInput = GetComponent<NewInput>();
        _rb = GetComponent<Rigidbody2D>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // FixedUpdate -> Fisicas
    void FixedUpdate()
    {
        Movement();
        PlayerMoveAnim();
        Flip();
    }

    public void Movement(){
        //transform.Translate(Vector3.right * speed * _newInput.inputX * Time.deltaTime);
        _rb.velocity = new Vector2(speed * _newInput.inputX, _rb.velocity.y);
        
    }

    public void PlayerMoveAnim(){
        _animator.SetBool("isMoving", _newInput.inputX != 0);
    }

    private void Flip()
    {

        _spriteRenderer.flipX = _newInput.inputX < 0;

    }

}
