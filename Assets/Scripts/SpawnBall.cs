using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SpawnBall : MonoBehaviour {

	int ShapeCount = 0;
	string ShapeString = "";
	public Material ShapeMaterial;

	public void SpawnShape () {
	
		GameObject MultiShape = GameObject.CreatePrimitive(PublicVar.ShapeName);
		MultiShape.AddComponent<Rigidbody>();
		MultiShape.GetComponent<MeshRenderer> ().material = ShapeMaterial;
		ShapeCount = ShapeCount + 1;
		ShapeString = ShapeCount.ToString();
		GameObject.Find ("ShapeCounter").GetComponent <Text> ().text = ShapeString;

	}
}
