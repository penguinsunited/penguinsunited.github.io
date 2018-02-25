using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToGameOver : MonoBehaviour {

	GameObject Player;
	// Use this for initialization
	void Start () {
		Player = GameObject.FindWithTag ("Player");
	}
	
	// Update is called once per frame
	void Update () {
		if (Player.transform.position.y <= -40) {
			SceneManager.LoadScene ("Game Over");
		}
			
			
	}
}
