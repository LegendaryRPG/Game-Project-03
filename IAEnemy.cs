// Creada por Ezequiel Merino, By Legendary Rpg en Unity 5.6.1 @2017
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IAEnemy : MonoBehaviour {

	public int estado = 0;
	AnimationClip Idle; // Estado = 0
	AnimationClip Caminar; // Estado = 1
	AnimationClip Correr; // Estado = 2
	AnimationClip Atk; // Estado = 3
	AnimationClip Dead; // Estado = 4
	public Transform PJ;

	// Use this for initialization
	void Start () {}
	
	// Update is called once per frame
	void Update () {
		if (estado == 0){GetComponent<Animation>().Play(Idle.name);}
		else if (estado == 1){GetComponent<Animation>().Play(Caminar.name); transform.Translate (0,0,0);}
		else if (estado == 2){transform.LookAt(PJ); GetComponent<Animation>().Play(Correr.name);
			transform.Translate (0,0,0);}
		else if (estado == 3){GetComponent<Animation>().Play(Atk.name);}
		else if (estado == 4){GetComponent<Animation>().Play(Dead.name); Destroy (this.gameObject, 1);}
	}

	void OnTriggerEnter (Collider other){
		if (other.gameObject.tag == "Player") {estado = 2;} // Rango de Deteccion
		if (other.gameObject.tag == "Player") {estado = 3;} // Rango de Ataque
	}

	void OnTriggerExit (Collider other){
		if (other.gameObject.tag == "Player") {estado = 0;} // Saliendo del Rango de Deteccion
		if (other.gameObject.tag == "Player") {estado = 2;} // Saliendo del Rango de Ataque
	}
}

