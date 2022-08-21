using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{
    [SerializeField] GameObject tree;
    bool nearGround = false;
    void OnCollisionEnter2D(Collision2D collision)
    {

        if(collision.gameObject.tag == "Ground" && nearGround == true)
        {
            Instantiate(tree, collision.contacts[0].point, Quaternion.identity);
            Destroy(gameObject);
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        nearGround = true;
    }
}