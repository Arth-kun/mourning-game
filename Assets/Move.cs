using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

	float speed = 5f;

	Rigidbody2D rb;

	void Start () {
		rb = GetComponent<Rigidbody2D> ();
	}

	// Update is called once per frame
	void Update () {
		Vector2 moveDir = Vector2.zero;
		moveDir.x = Input.GetAxis ("Horizontal");
		//moveDir.y = Input.GetAxis ("Vertical"); // Do jump instead of normal move

		rb.velocity = new Vector2 (moveDir.x * speed, 0);

		if (Input.GetKeyDown(KeyCode.UpArrow)) {
			rb.AddForce (new Vector2 (0, 10), ForceMode2D.Impulse);
		}
	}
}