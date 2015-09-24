using UnityEngine;
using System.Collections;

public class Success : MonoBehaviour {
	// Use this for initialization
		public Rigidbody2D rb;
		public BoxCollider2D bc;
		private bool tof = false;
		void Start () {
			rb = GetComponent<Rigidbody2D>();
			bc = GetComponent<BoxCollider2D>();
		}
		void OnTriggerEnter2D(Collider2D collider) {
		//Debug.Log ("Triggered: " + collider.name);
		if (collider.name == "topBun") {
			tof = true;
		}

	}

	private float move = 0.2f;
	void Update(){ 
			if (tof == true) {
			if (transform.position.x > -0.5f) {    
				transform.position = new Vector3 (transform.position.x - move, transform.position.y, transform.position.z);
			} else {
				this.rb.isKinematic = false;
			}
		}
		}
	}





