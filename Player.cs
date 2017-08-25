// Creada por Ezequiel Merino, By Legendary Rpg en Unity 5.6.1 @2017
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	static public int Exp;
	public int ExpOb;
	public static int VPlayer; // Vida actual del player
	public int VaPlayer;
	public int VMxPlayer = Atributos.EfVit2; // Vida max del player
	int DefFP = Atributos.EfVit1; // Defensa Fisica del Player
	int DefMP = Atributos.EfEne1; // Defensa Magica del Player
	int AtkFP = Atributos.EfFuer1; // Ataque Fisico del Player
	int AtkMP = Atributos.EfInt1; // Ataque Magico del Player

	// Use this for initialization
	void Start () {
		VPlayer = VMxPlayer;
	}
	
	// Update is called once per frame
	void Update () {
		VMxPlayer = Atributos.EfVit2;
		VaPlayer = VPlayer;
		ExpOb = Exp; // Solo muestra la experiencia en el editor
	}

}
