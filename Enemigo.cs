// Creada por Ezequiel Merino, By Legendary Rpg en Unity 5.6.1 @2017
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour {

	public double VidaE; // Vida Actual
	public double VidaEMax; // Vida Maxima
	public bool MuerteE = false; // Comprueva estado de muerte
	public bool RegE = true; // Activa la Regeneracion de Vida
	public int TasCurE = 4; // Restaura X puntos por Segundo
	public GameObject ObjDano; //Objeto que causa el daño
	public GameObject Efec_Muert; // efecto de Muerte
	public GameObject SolItem; // Items que suelta
	int DefFE; // Defensa Fisica del Enemigo
	int DefME; // Defensa Magica del Enemigo
	int AtkFE; // Ataque Fisico del Enemigo
	int AtkME; // Ataque Magico del Enemigo
	int RazaE; // Raza del Enemigo

	// Use this for initialization
	void Start () {VidaE = VidaEMax;}
	
	// Update is called once per frame
	void Update () {
		if (VidaE >= VidaEMax) {VidaE = VidaEMax; RegE = false;}
		if (VidaE < VidaEMax) {RegE = true;}
		if (VidaE <= 0 && MuerteE == true){Instantiate (Efec_Muert,transform.position,transform.rotation);
			Instantiate (SolItem,transform.position,transform.rotation); Player.Exp += 20; 
			DestroyImmediate (this.gameObject);}
		if (RegE == true) {VidaE += TasCurE * Time.deltaTime;}
	}

	void OnTriggerEnter (Collider ObjDano) {
		Player.VPlayer -= 20; // Daño Causado por Arma/Skill
	}

}
