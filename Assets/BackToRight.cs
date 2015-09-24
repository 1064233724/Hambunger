using UnityEngine;
using System.Collections;

public class BackToRight : MonoBehaviour {
	
	int numBGPanels = 6;
	// Use this for initialization
	void OnTriggerEnter2D(Collider2D collider) {
		if (collider.tag == "BG") {
			//Debug.Log ("Triggered: " + collider.name);
			
			float WidthOfBGObject = ((BoxCollider2D)collider).size.x;
			//Debug.Log(HeightOfBGObject);

			Vector3 pos = collider.transform.position;
			pos.x += WidthOfBGObject * numBGPanels;
			
			collider.transform.position = pos;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
