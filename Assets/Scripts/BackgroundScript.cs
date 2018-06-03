using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScript : MonoBehaviour
{

	public float Speed = 1f;
	
	private Animator animator;
	
	// Use this for initialization
	private void Start ()
	{
		animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		animator.speed = Speed;
	}
}
