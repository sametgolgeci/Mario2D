using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreManagerScript : MonoBehaviour {

	public Text scoreText;
	public static int score = 0;

	void Start () {
		GameObject ScoreGO = GameObject.Find ("Score");
		scoreText = ScoreGO.GetComponent<Text> ();
		scoreText.text = "0";
	}

	void Update () {
		scoreText.text = score.ToString ();
	}
}
