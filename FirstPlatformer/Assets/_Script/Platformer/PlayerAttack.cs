using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public float bounceForce;
    public Rigidbody2D _rb;

    public void Start(){
        _rb = GetComponent<Rigidbody2D>();
    }
    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.CompareTag("Enemy")){
            _rb.AddForce(transform.up * bounceForce, ForceMode2D.Impulse);
            collision.GetComponent<EnemyMovement>().canMove = false;
            Destroy(collision.gameObject, 1.5f);
        }

    }
}
