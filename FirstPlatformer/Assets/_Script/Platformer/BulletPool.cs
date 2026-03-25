using System.Collections.Generic;
using UnityEngine;

public class BulletPool : MonoBehaviour
{
    public GameObject bulletPrefab;  // en este caso, el prefab de ColorBullet
    public int poolSize = 3;         // máximo de balas activas para este tipo

    private List<GameObject> bullets;

    void Awake()
    {
        bullets = new List<GameObject>();

        for (int i = 0; i < poolSize; i++)
        {
            GameObject obj = Instantiate(bulletPrefab);
            obj.SetActive(false);
            bullets.Add(obj);
        }
    }

    public GameObject GetBullet()
    {
        foreach (var bullet in bullets)
        {
            if (!bullet.activeInHierarchy)
                return bullet;
        }
        return null; // no hay balas disponibles
    }
}