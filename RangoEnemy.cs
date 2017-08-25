using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangoEnemy : MonoBehaviour {
	public bool RangDeteccion;
	public bool RangAtk;
	// Use this for initialization
	//void Start () {}
	// Update is called once per frame
	//void Update () {}

	void OnTriggerEnter (Collider other){
		if ((other.gameObject.tag == "Player") && (RangDeteccion == true)){IAEnemy.estado = 2;} // Rango de Deteccion
		if ((other.gameObject.tag == "Player") && (RangAtk == true)){IAEnemy.estado = 3;} // Rango de Ataque
	}

	void OnTriggerExit (Collider other){
		if ((other.gameObject.tag == "Player") && (RangDeteccion == true)){IAEnemy.estado = 0;} // Saliendo del Rango de Deteccion
		if ((other.gameObject.tag == "Player") && (RangAtk == true)){IAEnemy.estado = 2;} // Saliendo del Rango de Ataque
	}
}
