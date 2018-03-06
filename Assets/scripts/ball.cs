using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour {
    public float thrust;
    public Rigidbody2D rb;
    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>();
        // rb.AddForce(new Vector2(20, 10), ForceMode2D.Impulse);
        rb.AddForce(new Vector2(2, 10 * Time.deltaTime), ForceMode2D.Impulse);
    }
	
	// Update is called once per frame
	void Update () {
        
    }
     
}
