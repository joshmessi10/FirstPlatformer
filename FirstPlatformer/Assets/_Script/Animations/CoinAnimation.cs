using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinAnimation : MonoBehaviour
{
    public Animator _anim;
    public int coinValue = 50;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CoinAnim();
    }

    public void CoinAnim(){
        if(Input.GetKeyDown(KeyCode.R)){
            _anim.SetTrigger("Anim");
        }
        
    }

    private void OnTriggerEnter2D(Collider2D collision){
        if (collision.CompareTag("Player"))
        {
            PlayerStats.score += coinValue;
            _anim.SetTrigger("Anim");
        }

    }
}
