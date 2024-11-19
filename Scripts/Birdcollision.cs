using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Birdcollision : MonoBehaviour
{
    public GameManager gameManager;
    void OnTriggerEnter2D(Collider2D other)
    {
      if (other.CompareTag("Enemy"))
      {
        gameManager.GameOver();
      }
      else if (other.CompareTag("Score"))
      {
        gameManager.AddScore();
      }
    }
}
