using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

	int XRandom;
	int YRandom;
	int ZRandom;


	void Update () {
	
		XRandom = (Random.Range (-50, 50));
		YRandom = (Random.Range (-50, 50));
		ZRandom = (Random.Range (-50, 50));

		Physics.gravity = new Vector3 (XRandom, YRandom, ZRandom);
	}
}
