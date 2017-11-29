using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eMove : MonoBehaviour {
	//public List<Transform> points;
	private Rigidbody2D enemy;
	public float speed;
	int currentPoint;
	public float startingPositionY;
	

	// Use this for initialization
	void Start()
	{
		enemy = this.GetComponent<Rigidbody2D>();

		currentPoint = 0;
	}

	// Update is called once per frame
	void Update()
	{
		/*
		Vector2 forceVec = this.transform.position - points[currentPoint].position;
		float dist = Vector2.Distance(this.transform.position,points[currentPoint].position);
		enemy.velocity = forceVec;

		Debug.Log(dist);

		if (dist <= 2)
		{
			if (currentPoint == 0)
			{
				currentPoint = 1;
			}
			else
			{
				currentPoint = 0;
			}
		}
		*/


		enemy.transform.position = new Vector3(enemy.transform.position.x, startingPositionY + Mathf.Sin(Time.time * speed), enemy.transform.position.z);


	}

}
