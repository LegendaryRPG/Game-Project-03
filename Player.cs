// Creada por Ezequiel Merino, By Legendary Rpg en Unity 5.6.1 @2017
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	static public int Exp;
	public int ExpOb;
	public static int VPlayer; // Vida actual
	public int VaPlayer;

	int PuntAtrib; // Puntos para aumentar atributos
	int AtkFP; // Ataque Fisico (Fuerza 1)
	int ResisP; // Resistencia (Fuerza 2)
	int BloqP; // Bloqueo (Fuerza 3)
	int EvacP; // Evacion (Agilidad 1)
	int VelAtkFP; // Velocidad de ataque fisico (Agilidad 2)
	int ParaP; // Parada (Agilidad 3)
	int DefFP; // Defensa Fisica (Vitalidad 1)
	int VMxPlayer; // Vida maxima (Vitalidad 2)
	int RegenVidP; // Regeneracion de vida (Vitalidad 3)
	int ResCritFP; // Resistencia a Critico Fisico (Vitalidad 4)
	int CritFP; // Posibilidad de Critico Fisico (Precision 1)
	int PrecisFP; // Precision Fisica (Precision 2)
	int TaxExiItem; // Posibilidades de exito en creacion de items (Precision 3)
	int AtkMP; // Ataque Magico (Inteligencia 1)
	int VelAtkMP; // Velocidad ataque magico (Inteligencia 2)
	int PrecisMP; // Precision Magica (Inteligencia 3)
	int CritMP; // Posibilidad critico magico (Inteligencia 4)
	int DefMP; // Defensa Magica (Energia 1)
	int ManaMaxP; // Mana maxima (Energia 2)
	int RegenManP; // Regeneracion de mana (Energia 3)
	int ResCritMP; // Resistencia critico magico (Energia 4)

	int[] HabPlayer; // Habilidades del Player

	void EstadPlayer(){
		AtkFP = Atributos.EfFuer1;
		ResisP = Atributos.EfFuer2;
		BloqP = Atributos.EfFuer3;
		EvacP = Atributos.EfAgi1;
		VelAtkFP = Atributos.EfAgi2;
		ParaP = Atributos.EfAgi3;
		DefFP = Atributos.EfVit1;
		VMxPlayer = Atributos.EfVit2;
		RegenVidP = Atributos.EfVit3;
		ResCritFP = Atributos.EfVit4;
		CritFP = Atributos.EfPrecis1;
		PrecisFP = Atributos.EfPrecis2;
		TaxExiItem = Atributos.EfPrecis3;
		AtkMP = Atributos.EfInt1;
		VelAtkMP = Atributos.EfInt2;
		PrecisMP = Atributos.EfInt3;
		CritMP = Atributos.EfInt4;
		DefMP = Atributos.EfEne1;
		ManaMaxP = Atributos.EfEne2;
		RegenManP = Atributos.EfEne3;
		ResCritMP = Atributos.EfEne4;
		PuntAtrib += Atributos.DistPuntAtrib ();
	}

	void HabilPlayer(){
		HabPlayer = Habilidades.Hab;
	}

	// Use this for initialization
	void Start () {
		VPlayer = VMxPlayer;
	}
	
	// Update is called once per frame
	void Update () {
		EstadPlayer ();
		HabilPlayer ();
		VaPlayer = VPlayer;
		ExpOb = Exp; // Solo muestra la experiencia en el editor
	}

}
