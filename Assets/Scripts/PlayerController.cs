using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] Rigidbody2D playerRB;
    [SerializeField] float moveSpeedFactor = 1;
    [SerializeField] float jumpHeight;
    bool touchingGround = false;
    void Update()
    {
        playerRB.velocity = new Vector2(Input.GetAxis("Horizontal") * moveSpeedFactor, playerRB.velocity.y);
        if(touchingGround == true && Input.GetKeyDown(KeyCode.Space))
        {
            playerRB.AddForce(new Vector2(playerRB.velocity.x, jumpHeight * 100));
            touchingGround = false;
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        touchingGround = true;
    }
    void OnTriggerExit2D(Collider2D other)
    {
        touchingGround = false;
    }
}
