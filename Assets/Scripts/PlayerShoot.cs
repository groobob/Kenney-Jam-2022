using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField] Camera mainCamera;
    [Space]
    [SerializeField] GameObject waterBullet;
    [SerializeField] GameObject growthDestroyBullet;
    [SerializeField] float bulletSpeedFactor;
    [SerializeField] float growthBulletDestroyTime;
    [SerializeField] int bulletCount = 3;
    Vector3 direction;
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0) && bulletCount > 0)
        {
            Vector3 mousePos = Input.mousePosition;
            mousePos.z = 0;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);
            Vector3 direction = mousePos - transform.position;
            direction.Normalize();

            GameObject projectile = Instantiate(waterBullet, transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody2D>().AddForce(direction * bulletSpeedFactor * 500);
            Destroy(projectile, 10f);

            bulletCount -= 1;
        }
        if(Input.GetKeyDown(KeyCode.Mouse1))
        {
            Vector3 mousePos = Input.mousePosition;
            mousePos.z = 0;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);
            Vector3 direction = mousePos - transform.position;
            direction.Normalize();

            GameObject projectile = Instantiate(growthDestroyBullet, transform.position, Quaternion.identity);
            projectile.GetComponent<Rigidbody2D>().AddForce(direction * bulletSpeedFactor * 500);
            Destroy(projectile, growthBulletDestroyTime);
        }
    }
    void CreateProjectile(GameObject bullet, float destroyTime, Vector3 aimLocation)
    {
        GameObject projectile = Instantiate(bullet, transform.position, Quaternion.identity);
            bullet.GetComponent<Rigidbody2D>().AddForce(aimLocation * bulletSpeedFactor * 500);
            Destroy(projectile, destroyTime);
    }
}
