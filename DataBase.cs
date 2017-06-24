// Creada por Ezequiel Merino, By Legendary Rpg en Unity 5.6.1 @2017
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataBase : MonoBehaviour {

	int IndHab; //Indice de Habilidad. (0-31)
	int IndAtr; //Indice de Atributo. (0-5)
	int IndHabExp; //Indice de Experiencia de Habilidad. (0-27)
	int PuntAtrb; // Puntos para agregar a los atributos.
	int[] ComHab; // Comprueba cambio de Habilidad.

	// Use this for initialization
	void Start () {}
	// Update is called once per frame
	void Update () {
		PuntAtrb += Atributos.DistPuntAtrib ();
		if(ComHab[IndHab] < Habilidades.Hab[IndHab]){ComHab [IndHab] = Habilidades.Hab [IndHab];}
	}

}
