using UnityEngine;
using System.Collections;

public class PowerUpScript : MonoBehaviour {

	public GameObject mushroom;
//	public GameObject fireFlower;
	public GameObject spawn;

	void OnTriggerEnter2D () {
		if (MarioControllerScript.playerState == 0) {
			Instantiate (mushroom, spawn.transform.position, Quaternion.identity);
		} else if (MarioControllerScript.playerState > 1) {
//			Instantiate (fireFlower, spawn.transform.position, Quaternion.identity);
		}
	}
}
