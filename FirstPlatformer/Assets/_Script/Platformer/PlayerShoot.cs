using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShoot : MonoBehaviour
{
    public BulletPool bulletPool; // pool de balas
    public BulletPool colorBulletPool;
    public Transform startPos;
    public int maxAmmo = 5;       // máximo de balas que puede tener
    private int currentAmmo = 0;  // balas disponibles actualmente

    void Start()
    {
        currentAmmo = 3; // empieza sin munición
    }

    // Método para disparar con Input Action (tecla J)
    public void Shoot(InputAction.CallbackContext context)
    {
        if (context.started && currentAmmo > 0)
        {
            GameObject bullet = bulletPool.GetBullet();
            if (bullet != null)
            {
                bullet.transform.position = startPos.position;
                bullet.transform.rotation = startPos.rotation;
                bullet.SetActive(true);
                currentAmmo--; // consumimos una bala
            }
        }
    }

    public void ShootColorBullet(InputAction.CallbackContext context)
    {
        if (context.started && currentAmmo > 0) // consumimos munición normal
        {
            GameObject bullet = colorBulletPool.GetBullet(); // o el pool correcto
            if (bullet != null)
            {
                bullet.transform.position = startPos.position;
                bullet.transform.rotation = startPos.rotation;

                Bullet bulletScript = bullet.GetComponent<Bullet>();
                if (bulletScript != null)
                {
                    bulletScript.isColorBullet = true;
                    bulletScript.colorOnImpact = Color.magenta; // o el color que quieras
                }

                bullet.SetActive(true);
                currentAmmo--; // consumimos una bala del inventario
            }
        }
    }

    // Método para recoger munición del suelo
    public void AddAmmo(int amount = 1)
    {
        currentAmmo += amount;
        if (currentAmmo > maxAmmo)
            currentAmmo = maxAmmo;
    }

    // Opcional: para mostrar la munición actual
    public int GetCurrentAmmo()
    {
        return currentAmmo;
    }
}