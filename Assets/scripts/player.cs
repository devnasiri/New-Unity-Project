using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class player : MonoBehaviour {
    float DirectionX;
    Rigidbody2D rb;
    Rigidbody2D Player1;
    public float delta = 1.5f;  // Amount to move left and right from the start point
    public float speed = 0.01f;
    private Vector3 player2Position;

    public Collider2D player1Collider;
    public Collider2D player2Collider;
    public Collider2D ballCollider;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>();
        player1Collider = GameObject.FindGameObjectWithTag("player1").GetComponent<Collider2D>();
        player2Collider = GameObject.FindGameObjectWithTag("player2").GetComponent<Collider2D>();
        ballCollider = GameObject.FindGameObjectWithTag("ball").GetComponent<Collider2D>();


       
    }
	
	// Update is called once per frame
	void Update () {
        DirectionX = CrossPlatformInputManager.GetAxis("Horizontal");
        Player1 = GameObject.FindGameObjectWithTag("player1").GetComponent<Rigidbody2D>();
        Player1.velocity = new Vector2(DirectionX * 100, 0);
    }

    public void jump()
    {
       // rb.AddForce(new Vector2(-5, - 10 * Time.deltaTime), ForceMode2D.Impulse);
    }
    public void FixedUpdate()
    {
       
        anemyMove();

    }

    public void anemyMove()
    {

        Vector2 ballPosition = GameObject.Find("ball").transform.position;
        player2Position = GameObject.FindGameObjectWithTag("player2").transform.position;

        if (ballPosition.x > 0 && player2Position.x > (ballPosition.x + 0.3) && ballPosition.y > -2.8)
        {
            //move anemy to the ball
            
            Vector3 v = player2Position;
            v.x -= 0.2f;
            GameObject.FindGameObjectWithTag("player2").transform.position = v;
            // GameObject.FindGameObjectWithTag("player2").transform.position = ballPosition;
        } else if (ballPosition.x > 0 && player2Position.x < (ballPosition.x +0.3)  && ballPosition.y > -2.8)
        {
            //move anemy to the ball

            Vector3 v = player2Position;
            v.x += 0.2f;
            GameObject.FindGameObjectWithTag("player2").transform.position = v;
            // GameObject.FindGameObjectWithTag("player2").transform.position = ballPosition;
        }

        if (ballCollider.IsTouching(player2Collider))
        {
           // rb.AddForce(new Vector2(-5, 10 * Time.deltaTime), ForceMode2D.Impulse);
            rb.AddForce(new Vector2(-10, 10), ForceMode2D.Impulse);
        }
    }

}
