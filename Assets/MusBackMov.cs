using UnityEngine;
using System.Collections;

public class MusBackMov : MonoBehaviour {
	
	Rigidbody2D rg2d;
	
	// Use this for initialization
	void Start () {
		rg2d = gameObject.GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 temp = rg2d.position;
		temp.x -= 0.03f	;
		rg2d.transform.position = temp;
	}
}