using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {
	public List<Transform> points;
	public Rigidbody2D enemy;
	float speed;
	int currentPoint;

		// Use this for initialization
	void Start () {
		enemy = this.GetComponent<Rigidbody2D>();
		speed = 6;
		currentPoint = 0;
	}
	
	// Update is called once per frame
	void Update () {	
		Vector2 forceVec = this.transform.position - points[currentPoint].position;
		float dist = Vector3.Distance(points[currentPoint].position, this.transform.position);
		enemy.velocity = forceVec;

	}


}
