using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {
    public float speed = 30;

    public Rigidbody2D rigidBody;

	// Use this for initialization
	void Start () {
        rigidBody = GetComponent<Rigidbody2D>();

        rigidBody.velocity = Vector2.up * speed;
	}
	
	// Update is called once per frame
	void OnTriggerEnter2D (Collider2D col) {
	    if (col.tag == "Wall")
	    {

	    }
	}

    
}
