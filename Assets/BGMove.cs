using UnityEngine;
using System.Collections;

public class BGMove : MonoBehaviour {

	int numBGPanels = 3;
	float dY = 0.1f;
	// Use this for initialization
	void OnTriggerEnter2D(Collider2D collider) {
		if (collider.tag == "BG") {
			//Debug.Log ("Triggered: " + collider.name);

			float HeightOfBGObject = ((BoxCollider2D)collider).size.y;
			//Debug.Log(HeightOfBGObject);

			Vector3 pos = collider.transform.position;
			pos.y += HeightOfBGObject * numBGPanels;

			pos.y -= dY;

			collider.transform.position = pos;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
