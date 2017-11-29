using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerReset : MonoBehaviour {

	//public GameObject spawn;
	public GameObject player;

	private void OnTriggerEnter2D(Collider2D other)
	{

		if (other.tag == "Player")
		{
			other.transform.position = new Vector2(-3, 1);
		
			//Instantiate(player, spawn.transform.position, spawn.transform.rotation);
			//Destroy(other.gameObject);
		}

	}


}
