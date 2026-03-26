using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShoot : MonoBehaviour
{
    [Header("Pools")]
    public BulletPool bulletPool;        // pool de balas normales
    public BulletPool colorBulletPool;   // pool de balas de color

    [Header("Disparo")]
    public Transform startPos;

    [Header("Munición")]
    public int maxAmmo = 5;
    private int currentAmmo = 0;

    void Start()
    {
        currentAmmo = 3; // munición inicial
    }

    // Disparo normal (tecla J)
    public void Shoot(InputAction.CallbackContext context)
    {
        if (context.performed && currentAmmo > 0)
        {
            GameObject bullet = bulletPool.GetBullet();

            if (bullet != null)
            {
                bullet.transform.position = startPos.position;
                bullet.transform.rotation = startPos.rotation;
                bullet.SetActive(true);

                currentAmmo--;
            }
            else
            {
                Debug.Log("No hay balas normales disponibles en el pool");
            }
        }
    }

    // Disparo de color (tecla K)
    public void ShootColorBullet(InputAction.CallbackContext context)
    {
        if (context.performed && currentAmmo > 0)
        {
            GameObject bullet = colorBulletPool.GetBullet();

            if (bullet != null)
            {
                bullet.transform.position = startPos.position;
                bullet.transform.rotation = startPos.rotation;
                bullet.SetActive(true);

                currentAmmo--;
            }
            else
            {
                Debug.Log("No hay balas de color disponibles en el pool");
            }
        }
    }

    // Recoger munición
    public void AddAmmo(int amount = 1)
    {
        currentAmmo += amount;

        if (currentAmmo > maxAmmo)
            currentAmmo = maxAmmo;
    }

    // Para UI o debug
    public int GetCurrentAmmo()
    {
        return currentAmmo;
    }
}