using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightTrigger : MonoBehaviour {
	public Light areaLight;
	public Light light;
	public Light light1;
	public Light light2;
	public Light light3;
	public Light light4;
	public Light light5;
	public Light light6;
	public Light light7;

	// Use this for initialization
	void Start () {
		areaLight.enabled	= false;
		light.enabled 		= false;
		light1.enabled 		= false;
		light2.enabled 		= false;
		light3.enabled 		= false;
		light4.enabled 		= false;
		light5.enabled 		= false;
		light6.enabled 		= false;
		light7.enabled 		= false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	//if the sphere is in contact with the cube
	//turn all the light on
	void OnCollisionEnter(Collision col){
		if (col.gameObject.name == "Cube") {
			areaLight.enabled	= true;
			light.enabled		= true;
			light1.enabled 		= true;
			light2.enabled 		= true;
			light3.enabled 		= true;
			light4.enabled 		= true;
			light5.enabled 		= true;
			light6.enabled 		= true;
			light7.enabled 		= true;
		}
	}

	//if the sphere is not in contact with the cube
	//turn all the light off
	void OnCollisionExit(Collision col){
		if (col.gameObject.name == "Cube") {
			areaLight.enabled	= false;
			light.enabled 		= false;
			light1.enabled 		= false;
			light2.enabled 		= false;
			light3.enabled 		= false;
			light4.enabled 		= false;
			light5.enabled 		= false;
			light6.enabled 		= false;
			light7.enabled 		= false;
		}
	}
}
