using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CoinScript : MonoBehaviour {

	int coinValue = 1;

	// Use this for initialization
	void Start (){
		
	}

	void OnTriggerEnter2D () {
		Destroy (gameObject);
		ScoreManagerScript.score += coinValue;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}