using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IA : MonoBehaviour {

	float speed = 2.5f;

	Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
	}

	// Update is called once per frame
	void Update () {
		rb.velocity = new Vector2 (speed, 0);
	}

	void OnTriggerEnter2D (Collider2D col) {
		if (col.tag == "triggerIA") {
			rb.velocity = new Vector2 (0, 0);
			rb.AddForce (new Vector2 (0, 200), ForceMode2D.Impulse);
		}
	}
}