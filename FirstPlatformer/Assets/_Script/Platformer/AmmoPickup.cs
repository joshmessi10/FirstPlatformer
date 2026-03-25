using UnityEngine;

public class AmmoPickup : MonoBehaviour
{
    public int ammoAmount = 1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerShoot player = collision.GetComponent<PlayerShoot>();
        if (player != null)
        {
            player.AddAmmo(ammoAmount); // le da munición al jugador
            Destroy(gameObject); // desaparece del suelo
        }
    }
}