using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour {

	public GameObject Cube;
	public float Speed;
	public float RightMax;
	public float LeftMax;
	public float UpMax;
	public float DownMax;
	int RandomNo;
	int MaxZ;
	int MinZ;

	void Start (){
		RandomNo = Random.Range (-5, 10);
		MaxZ = 90;
		MinZ = -5;
	}

	// Update is called once per frame
	void Update () {
		Vector3 cVec = new Vector3 (Cube.transform.position.x, Cube.transform.position.y, Cube.transform.position.z);

		if (RandomNo == 0) {
			RandomNo += 1;
		}
		if (cVec.z - RandomNo <= MinZ) {
			RandomNo += Random.Range (20, 80);
		} else if (cVec.z + RandomNo >= MaxZ) {
			RandomNo -= Random.Range (20, 80);
		} 

		if (cVec.y >= UpMax && cVec.x >= LeftMax) {
			cVec.y = UpMax;
			TranslateLeft ();
		}
		if (cVec.x <= LeftMax && cVec.y >= DownMax) {
			cVec.x = LeftMax;
			TranslateDown ();
		}
		if (cVec.y <= DownMax && cVec.x <= RightMax) {
			cVec.y = DownMax;
			TranslateRight ();
		}
		if (cVec.x >= RightMax && cVec.y <= UpMax) {
			cVec.x = RightMax;
			TranslateUp ();
		}
	}

	void TranslateLeft(){
		Cube.transform.Translate (Speed / -200, 0, 0);
	}

	void TranslateRight() {
		Cube.transform.Translate (Speed / 500, 0, Speed / (RandomNo * 50));
	}

	void TranslateDown (){
		Cube.transform.Translate (0, Speed / -200, 0);
	}

	void TranslateUp (){
		Cube.transform.Translate (0, Speed / 200, 0);
	}
}
