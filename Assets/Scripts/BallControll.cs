using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControll : MonoBehaviour
{
    private Rigidbody2D rb;
    public float xInitialForce;
    public float yInitialForce;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        RestartGame();
    }

    void ResetBall()
    {
        //reset posisi circle
        transform.position = Vector2.zero;

        //reset kecepatan circle
        rb.velocity = Vector2.zero;
    }

    void PushBall()
    {
        //untuk random arah bola
        float randomDirection = Random.Range(0,2);

        //Jika nilai random dibawah 1 bola ke kekiri
        //selain itu bola bergerak kekanan
        if(randomDirection < 1.0f)
        {
            rb.AddForce(new Vector2(-xInitialForce, -yInitialForce));
        }else
        {
            rb.AddForce(new Vector2(xInitialForce, yInitialForce));
        }
    }

    void RestartGame()
    {
        //kembali ke posisi semula
        ResetBall();

        //bola bergerak
        Invoke("PushBall", 0.01f);
    }
}
