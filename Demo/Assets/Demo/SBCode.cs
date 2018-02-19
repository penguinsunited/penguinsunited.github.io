using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SBCode : MonoBehaviour {

	public Material Sky;

	// Use this for initialization
	void Start () {
		RenderSettings.skybox = Sky;
	}

}
