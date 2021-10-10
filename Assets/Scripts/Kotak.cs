using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kotak : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            ScoreManager.Instance.AddScore(1);
            Destroy(gameObject);
        }
    }
}
