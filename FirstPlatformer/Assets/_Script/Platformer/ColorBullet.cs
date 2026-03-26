using UnityEngine;

public class ColorBullet : MonoBehaviour
{
    private Rigidbody2D _rb;
    public float speed = 10f;

    public Color colorOnImpact = Color.magenta;

    void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void OnEnable()
    {
        _rb.velocity = transform.right * speed;
    }

    private Color GetRandomColor()
    {
        return new Color(
            Random.value,
            Random.value,
            Random.value
        );
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
            return;

        if (collision.CompareTag("Enemy"))
        {
            SpriteRenderer sr = collision.GetComponent<SpriteRenderer>();
            if (sr != null)
            {
                colorOnImpact = GetRandomColor();
                sr.color = colorOnImpact;
            }
        }

        Disable();
    }

    private void Disable()
    {
        _rb.velocity = Vector2.zero;
        gameObject.SetActive(false);
    }
}