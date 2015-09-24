using UnityEngine;
using System.Collections;

public class news : MonoBehaviour {
	// Use this for initialization
	void OnTriggerEnter2D(Collider2D collider) {
		//Debug.Log ("Triggered: " + collider.name);

		if (collider.tag == "hit") {
			collider.attachedRigidbody.isKinematic = true;
		}
	}
}

