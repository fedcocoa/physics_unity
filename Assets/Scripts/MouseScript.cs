using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseScript : MonoBehaviour {



	void Start () {
		
	}
	

	void Update () {

		gameObject.transform.position = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, 0);


	}
}
