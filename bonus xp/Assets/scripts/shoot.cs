using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour {

	public Transform arrowSpawn;
	public GameObject arrow;
	public float nextFire = 1.0f;
	private float myTime = 0.5f;

	
	// Update is called once per frame
	void Update () {
		myTime = myTime + Time.deltaTime;

		if (myTime > nextFire)
		{
			Instantiate(arrow, arrowSpawn.position, arrowSpawn.rotation);
			myTime = 0.0f;
		}
	}
}
