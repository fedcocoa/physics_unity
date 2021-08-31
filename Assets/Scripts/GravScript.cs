using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class GravScript : MonoBehaviour {

	public float XSlider;
	public float YSlider;
	public float ZSlider;

	public void Changed () {
	
		XSlider = GameObject.Find ("XGravitySlider").GetComponent <Slider> ().value;
		YSlider = GameObject.Find ("YGravitySlider").GetComponent <Slider> ().value;
		ZSlider = GameObject.Find ("ZGravitySlider").GetComponent <Slider> ().value;

		Physics.gravity = new Vector3 (XSlider, YSlider, ZSlider);
	}
}
