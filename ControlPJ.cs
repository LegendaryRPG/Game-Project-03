// Creada por Ezequiel Merino, By Legendary Rpg en Unity 5.6.1 @2017
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPJ : MonoBehaviour {

	public int Vel_Mov = 10;
	// Use this for initialization
	void Start () {}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.W)) {transform.Translate (0, 0, Vel_Mov * Time.deltaTime);}
		if (Input.GetKey (KeyCode.S)) {transform.Translate (0, 0, -Vel_Mov * Time.deltaTime);}
		if (Input.GetKey (KeyCode.A)) {transform.Rotate (-Vel_Mov * Time.deltaTime, 0, 0);}
		if (Input.GetKey (KeyCode.D)) {transform.Rotate (Vel_Mov * Time.deltaTime, 0, 0);}

		if (Input.GetKeyDown (KeyCode.Mouse0)) {transform.Translate (0,0,1 * Time.deltaTime);}
	}
}
