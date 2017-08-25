// Creada por Ezequiel Merino, By Legendary Rpg en Unity 5.6.1 @2017
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPJ : MonoBehaviour {

	public int Vel_Mov = 10;
	public int Vel_Rot = 30;
	// Use this for initialization
	void Start () {}
	
	// Update is called once per frame
	void Update () {
		Movement ();
		Rotaten ();
	}

	void Movement(){
		if (Input.GetKey (KeyCode.W)) {transform.Translate (Vector3.forward * Vel_Mov * Time.deltaTime);}
		else if (Input.GetKey (KeyCode.S)) {transform.Translate (Vector3.back * Vel_Mov * Time.deltaTime);}
		else if (Input.GetKey (KeyCode.A)) {transform.Translate (Vector3.left * Vel_Mov * Time.deltaTime);}
		else if (Input.GetKey (KeyCode.D)) {transform.Translate (Vector3.right * Vel_Mov * Time.deltaTime);}
	}

	void Rotaten(){
		if (Input.GetKey (KeyCode.Q)) {transform.Rotate (new Vector3 (0, -Vel_Rot, 0) * Time.deltaTime);}
		else if (Input.GetKey (KeyCode.E)) {transform.Rotate (new Vector3(0, Vel_Mov, 0) * Time.deltaTime);}
	}
}
