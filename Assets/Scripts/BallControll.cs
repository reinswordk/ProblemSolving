using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControll : MonoBehaviour
{
    private Rigidbody2D rb;
    //public float xInitialForce;
    //public float yInitialForce;

    public float speed;
    public const string Right = "right";
    public const string Left = "left";
    public const string Up = "up";
    public const string Down = "down";

    string buttonPressed;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        RestartGame();
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            buttonPressed = Up;
        }else if(Input.GetKey(KeyCode.S))
        {
            buttonPressed = Down;
        }else if(Input.GetKey(KeyCode.A))
        {
            buttonPressed = Left;
        }else if(Input.GetKey(KeyCode.D))
        {
            buttonPressed = Right;
        }else
        {
            buttonPressed = null;;
        }
    }

    void FixedUpdate()
    {
        if(buttonPressed == Right)
        {
            rb.AddForce(new Vector2(speed, 0));
        }else if(buttonPressed == Left)
        {
            rb.AddForce(new Vector2(-speed,0));
        }else if(buttonPressed == Up)
        {
            rb.AddForce(new Vector2(0, speed));
        }else if(buttonPressed == Down)
        {
            rb.AddForce(new Vector2(0, -speed));
        }else
        {}
    }

    void ResetBall()
    {
        //reset posisi circle
        transform.position = Vector2.zero;

        //reset kecepatan circle
        rb.velocity = Vector2.zero;
    }

   /*void PushBall()
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
    }*/

    void RestartGame()
    {
        //kembali ke posisi semula
        ResetBall();

        //bola bergerak
        //Invoke("PushBall", 0.01f);
    }
}
