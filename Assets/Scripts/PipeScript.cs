using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PipeScript : MonoBehaviour {
	// This global variable will be set from the inspector. Represents the speed of an obstacle
	public Vector2 pipeVelocity = new Vector2();

	public Text Counter;
	
	// function to be executed once the pipe is created
	void Start () {
		// Set the speed of the rigid body component attached to an obstacle
		GetComponent<Rigidbody2D>().velocity = pipeVelocity;

		Counter = GameObject.Find("Counter").GetComponent<Text>();
	}
 
	// function to be executed at each frame
	void Update () {
		// Check position x
		if(transform.position.x<-4){
			// Destroy the obstacle and clear the memory
			Destroy(gameObject);
			
			Counter.text = (float.Parse(Counter.text) + 0.5).ToString();
		}
	}
}
