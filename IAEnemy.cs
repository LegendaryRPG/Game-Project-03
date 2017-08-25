// Creada por Ezequiel Merino, By Legendary Rpg en Unity 5.6.1 @2017
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IAEnemy : MonoBehaviour {

	public static int estado = 0;
	public int VEstado;
	public AnimationClip Idle; // Estado = 0
	public AnimationClip Caminar; // Estado = 1
	public AnimationClip Correr; // Estado = 2
	public AnimationClip Atk; // Estado = 3
	public AnimationClip Dead; // Estado = 4
	public Transform PJ;

	// Use this for initialization
	void Start () {}
	
	// Update is called once per frame
	void Update () {
		VEstado = estado;
		if (estado == 0){GetComponent<Animation>().Play(Idle.name);}
		else if (estado == 1){GetComponent<Animation>().Play(Caminar.name); 
			transform.Translate (0,0,1*Time.deltaTime);}
		else if (estado == 2){transform.LookAt(PJ); GetComponent<Animation>().Play(Correr.name);
			transform.Translate (0,0,2*Time.deltaTime);}
		else if (estado == 3){GetComponent<Animation>().Play(Atk.name);}
		else if (estado == 4){GetComponent<Animation>().Play(Dead.name);}
	}
}

