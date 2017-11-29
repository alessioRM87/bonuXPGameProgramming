using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover : MonoBehaviour {
	// Public variables
	public float speed;
	public GameObject crossBow;

	// Private variables
	private Rigidbody2D rBody;

	// Use this for initialization
	void Start()
	{
		rBody = this.GetComponent<Rigidbody2D>();
		rBody.velocity = this.transform.right * speed;
	}
}
