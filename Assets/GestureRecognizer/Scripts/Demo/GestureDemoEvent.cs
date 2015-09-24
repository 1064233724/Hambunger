﻿using UnityEngine;
using System.Collections;
using GestureRecognizer;

// !!!: Drag & drop a GestureRecognizer prefab on to the scene first from Prefabs folder!!!
public class GestureDemoEvent : MonoBehaviour {

    // Subscribe your own method to OnRecognition event 
    void OnEnable() {
        GestureBehaviour.OnRecognition += OnGestureRecognition;
    }

    // Unsubscribe when this game object or monobehaviour is disabled.
    // If you don't unsubscribe, this will give an error.
    void OnDisable() {
        GestureBehaviour.OnRecognition -= OnGestureRecognition;
    }

    // Unsubscribe when this game object or monobehaviour is destroyed.
    // If you don't unsubscribe, this will give an error.
    void OnDestroy() {
        GestureBehaviour.OnRecognition -= OnGestureRecognition;
    }

    /**
     * Your own method. This method will be called by GestureBehaviour
     * automatically when a gesture is recognized. You can write your own script
     * in this method (kill enemies, shoot a fireball, or cast some spell etc.)
     * This method's signature should match the signature of OnRecognition event,
     * so your method should always have one parametre with the type of Result. Example:
     * 
     * void MyMethod(Result gestureResult) {
     *     kill enemy,
     *     shoot fireball,
     *     cast spell etc.
     * }
     * 
     * You can decide what to do depending on the name of the gesture and its score.
     * For example, let's say, if the player draws the letter of "e" (let's name the 
     * gesture "Fireball") and it is 50% similar to our "Fireball" gesture, shoot a fireball:
     * 
     * void MagicHandler(Result magicGesture) {
     * 
     *    if (magicGesture.Name == "Fireball" && magicGesture.Score >= 0.5f) {
     *        Instantiate(fireball, transform.position, Quaternion.identity);
     *    }
     * 
     * }
     * 
     * !: You can name this method whatever you want, but you should use the same name
     * when subscribing and unsubscribing. If your method's name is MagicHandler like above,
     * then:
     * 
     * void OnEnable() {
     *   GestureBehaviour.OnRecognition += MagicHandler;
     * }
     */
    void OnGestureRecognition(Result r) {
        Debug.Log("Gesture is " + r.Name + " with a score of " + r.Score);
    }


	void OnGUI() {
		GUI.Label(new Rect(0, 0, Screen.width, 50),"Left click and drag to draw on the screen and recognize");
	}
}