// Creada por Ezequiel Merino, By Legendary Rpg en Unity 5.6.1 @2017
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	static public int Exp;
	public int ExpOb;
	int DefFP; // Defensa Fisica del Player
	int DefMP; // Defensa Magica del Player
	int AtkFP; // Ataque Fisico del Player
	int AtkMP; // Ataque Magico del Player

	// Use this for initialization
	void Start () {}
	
	// Update is called once per frame
	void Update () {
		ExpOb = Exp; // Solo muestra la experiencia en el editor
	}

}
