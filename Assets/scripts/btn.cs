using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 
public class btn : MonoBehaviour {


    
    public Rigidbody2D rb;
	// Use this for initialization
	void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void jumpBall()
    {
        Debug.Log("test");
        rb.AddForce(new Vector2(2, 10 ), ForceMode2D.Impulse);
    }
}
