using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinBehaviour : MonoBehaviour
{
    GameObject[] getCount;
    void OnTriggerEnter2D(Collider2D other)
    {
        getCount = GameObject.FindGameObjectsWithTag ("Coin");
        if(other.gameObject.tag == "Player" && getCount.Length == 1)
        {
            GetComponent<SceneLoader>().LoadNextScene();
        }
        else if(other.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
