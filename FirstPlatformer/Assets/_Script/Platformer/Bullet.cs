using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Rigidbody2D _rb;
    private SpriteRenderer _sr;
    public float speed = 10f;
    
    [Header("Bala especial")]
    public bool isColorBullet = false; // true si esta bala cambia color del enemigo
    public Color colorOnImpact = Color.green; // color que aplicará al enemigo

    void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
        _sr = GetComponent<SpriteRenderer>();
    }

    private void OnEnable()
    {
        _rb.velocity = transform.right * speed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
            return;

        if (collision.CompareTag("Enemy"))
        {
            if (isColorBullet)
            {
                // Cambiar color del enemigo en lugar de destruirlo
                SpriteRenderer enemySr = collision.GetComponent<SpriteRenderer>();
                if (enemySr != null)
                    enemySr.color = colorOnImpact;
            }
            else
            {
                Destroy(collision.gameObject); // bala normal destruye
            }
        }

        // Siempre desactiva la bala
        Disable();
    }

    private void Disable()
    {
        _rb.velocity = Vector2.zero;
        gameObject.SetActive(false);
    }
}