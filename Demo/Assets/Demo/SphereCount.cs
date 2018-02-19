using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SphereCount : MonoBehaviour {

	private Text count;
	int SphereTotal;

	void Awake () {
		count = GameObject.Find ("Text").GetComponent<Text>();
		SphereTotal = 0;
	}

	void Update (){
		count.text = "Sphere Count: " + SphereTotal;

		if (SphereTotal == 5) {
			SceneManager.LoadScene ("Congrats");
		}
	}


	void OnCollisionEnter (Collision col)
	{
		if (col.gameObject.CompareTag("GoalObject")) {
			SphereTotal += 1;
		}
	}
		
}
