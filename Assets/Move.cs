using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Text;

public class Move : MonoBehaviour {

	float speed = 10f;

	Rigidbody2D rb;
	bool grounded = true;

	void Start () {
		Debug.Log("Hello");
		rb = GetComponent<Rigidbody2D> ();
	}

	void OnCollisionEnter2D (Collision2D col) {
		Debug.Log("col.gameObject.tag: " + col.gameObject.tag );
		if(col.gameObject.tag == "Floor")
			grounded = true;
		Debug.Log("Collision after: " + grounded );
	}

	// Update is called once per frame
	void Update () {
		Vector2 moveDir = Vector2.zero;
		moveDir.x = Input.GetAxis ("Horizontal");
		//moveDir.y = Input.GetAxis ("Vertical"); // Do jump instead of normal move

		rb.velocity = new Vector2 (moveDir.x * speed, 0);

		if (Input.GetKeyDown(KeyCode.UpArrow)) {
			if (grounded) { // can jump
            	//rig.AddForce (Vector3.up * jumpPower, ForceMode2D.Impulse);
				rb.AddForce (new Vector2 (0, 200), ForceMode2D.Impulse);
				//transform.Translate(Vector3.up * 260 * Time.deltaTime, Space.World);
            	grounded = false; //Avoid direct double jump
        	}
		}
	}
}