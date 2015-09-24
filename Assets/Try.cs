using UnityEngine;
using System.Collections;

public class Try : MonoBehaviour {

	
	void Start() {
		GameObject monster = (GameObject)Instantiate(Resources.Load("BG2"));
	}
	
	void Update() {
	}
} 