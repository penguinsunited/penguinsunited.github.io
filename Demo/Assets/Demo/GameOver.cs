using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver : MonoBehaviour {

	GameObject Text1;
	GameObject Text2;
	public float Time1;
	public float Time2;

	void Start (){
		Text1 = GameObject.FindWithTag ("GameOver");
		Text2 = GameObject.FindWithTag ("Continue");
		Text1.GetComponent<Text> ().enabled = true;
		Text2.GetComponent<Text> ().enabled = false;
	}
	// Update is called once per frame
	void Update () {
		if (Time.timeSinceLevelLoad >= Time1) {
			Text1.GetComponent<Text> ().enabled = false;
		}
		if (Time.timeSinceLevelLoad >= Time1 + Time2) {
			Text2.GetComponent<Text> ().enabled = true;
		}
		if (Input.GetKeyUp ("space")) {
			SceneManager.LoadScene("Main Level");
		}
		
	}

	void TextOff (bool Text){
		
	}
}
