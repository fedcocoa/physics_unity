using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PublicVar {

	public static PrimitiveType ShapeName = PrimitiveType.Sphere;

}

public class ShapeSelector : MonoBehaviour {

	void Start () {

		PublicVar.ShapeName = PrimitiveType.Sphere;
	
	}

	public void ValueChanged () {
	
		if (GameObject.Find ("ShapeDrop").GetComponent <Dropdown> ().value == 0)
			PublicVar.ShapeName = PrimitiveType.Sphere;

		if (GameObject.Find ("ShapeDrop").GetComponent <Dropdown> ().value == 1)
			PublicVar.ShapeName = PrimitiveType.Cube;

		if (GameObject.Find ("ShapeDrop").GetComponent <Dropdown> ().value == 2)
			PublicVar.ShapeName = PrimitiveType.Capsule;
		


	}
}