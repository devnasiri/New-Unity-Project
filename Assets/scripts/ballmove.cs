using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballmove : MonoBehaviour {
    public Rigidbody2D rb;
    public GameObject go;

    public Collider2D player1Collider;
    public Collider2D player2Collider;
    public Collider2D ballCollider;

    // Use this for initialization
    void Start () {
        rb = go.GetComponent<Rigidbody2D>();
        player1Collider = GameObject.FindGameObjectWithTag("player1").GetComponent<Collider2D>();
        player2Collider = GameObject.FindGameObjectWithTag("player2").GetComponent<Collider2D>();
        ballCollider = GameObject.FindGameObjectWithTag("ball").GetComponent<Collider2D>();

    }

    // Update is called once per frame
    void Update () {
		
	}
    public void bounceball()
    {

        if (ballCollider.IsTouching(player1Collider))
        {
            rb.AddForce(new Vector2(20, 15), ForceMode2D.Impulse);
        }
        /*-if (ballCollider.IsTouching(player1Collider))
        {
            // Do something;
            Debug.Log(Time.deltaTime);
            rb.AddForce(new Vector2(15, 15), ForceMode2D.Impulse);
        }
        else if (ballCollider.IsTouching(player2Collider))
        {
            Debug.Log(Time.deltaTime);
            // Do something;
            rb.AddForce(new Vector2(-15, 15),  ForceMode2D.Impulse);
        }*/

    }
}
