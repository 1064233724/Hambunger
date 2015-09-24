using UnityEngine;
using System.Collections;
using GestureRecognizer;

public class OurGesture : MonoBehaviour {

	void OnGestureRecognition(Result r){
		Debug.Log ("Gesture is " + r.Name + " and scored: " + r.Score);
	}

	void OnEnable() {
		GestureBehaviour.OnRecognition += OnGestureRecognition;
	}
	void OnDisable() {
		GestureBehaviour.OnRecognition -= OnGestureRecognition;
	}
	void OnDestroy() {
		GestureBehaviour.OnRecognition -= OnGestureRecognition;
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
