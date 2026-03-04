using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformAnimation : MonoBehaviour
{
    public Animator _platformAnim;
    public Collider2D _platformCollider; 
    public bool disableGameObjectAtEnd = true; 

    // Detecta cuando el jugador cae sobre la plataforma
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            _platformAnim.SetTrigger("onPlayer");
        }
    }

    
    public void OnAnimationEnd()
    {
        if (_platformCollider != null)
            _platformCollider.enabled = false;

        if (disableGameObjectAtEnd)
            gameObject.SetActive(false);
    }
}
