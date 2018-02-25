using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour {


	public GameObject SphereGoal;
	public GameObject SphereToActivate;


	void OnCollisionEnter (Collision col)
	{
		if (col.gameObject.name == "ThirdPersonController") {
			DestroyObject (SphereGoal);
			SphereToActivate.SetActive (true);
		}
	}
}
