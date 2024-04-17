using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerColission : MonoBehaviour
{
    public PlayerMovement moviment;

    void OnCollisionEnter(Collision collisionInfo)
    {
    
        if (collisionInfo.collider.tag == "obstacle")
        {
           moviment.enabled = false;
           FindObjectOfType<GameManager>().EndGame();
        }

    }
}
