using UnityEngine;
using System.Collections;

public class Hover : MonoBehaviour {

	Rigidbody2D rg2d;
	bool tof = true;
	int counter = 0;
	// Use this for initialization
	void Start () {
		rg2d = gameObject.GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (tof == true) {
			counter ++;
			Vector3 temp = rg2d.position;
			temp.y -= 0.003f;
			rg2d.transform.position = temp;
			if (counter == 150)
			{
				tof = false;
				counter =0;
			}
		} 
		else {
			counter++;
			Vector3 temp = rg2d.position;
			temp.y += 0.003f;
			rg2d.transform.position = temp;
			if (counter == 150)
			{
				tof = true;
				counter =0;
			}
		}
	}
}
