using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] Rigidbody2D playerRB;
    [SerializeField] float moveSpeedFactor = 1;
    [SerializeField] float jumpHeight;

    void Update()
    {
        playerRB.velocity = new Vector2(Input.GetAxis("Horizontal") * moveSpeedFactor, playerRB.velocity.y);
        if(Input.GetKeyDown(KeyCode.Space))
        {
            playerRB.AddForce(new Vector2(playerRB.velocity.x, jumpHeight));
        }
    }
}
