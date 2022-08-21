using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField] Camera mainCamera;
    [Space]
    [SerializeField] GameObject bullet;
    [SerializeField] float bulletSpeedFactor;
    [SerializeField] int bulletCount = 3;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0) && bulletCount > 0)
        {
            Vector3 mousePos = Input.mousePosition;
            mousePos.z = 0;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);
            Vector3 direction = mousePos - transform.position;
            direction.Normalize();

            GameObject projectile = Instantiate(bullet, transform.position, Quaternion.identity);
            Rigidbody2D projectileRB = projectile.GetComponent<Rigidbody2D>();
            projectileRB.AddForce(direction * bulletSpeedFactor * 500);
            Destroy(projectile, 20f);
            
            bulletCount -= 1;
        }
    }
}
