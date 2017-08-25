// Creada por Ezequiel Merino, By Legendary Rpg en Unity 5.6.1 @2017
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atributos : MonoBehaviour {

	public static int[] Atrib = new int[6]{5,5,5,5,5,5};
	//Fuerza (0)
	public static int EfFuer1; //  Atk Fisico(Mele)
	public static int EfFuer2; //  Resistencia
	public static int EfFuer3; //  Bloqueo
	//Agilidad (1)
	public static int EfAgi1; //  Evacion
	public static int EfAgi2; //  Velocidad Atk(Fisico)
	public static int EfAgi3; //  Parada
	//Vitalidad (2)
	public static int EfVit1; //  Defensa(Fisica)
	public static int EfVit2; //  Vida
	public static int EfVit3; //  Regeneracion de Vida
	public static int EfVit4; //  Resistencia a Critico fisico
	//Precision (3)
	public static int EfPrecis1; //  Posibilidad de Critico Fisico
	public static int EfPrecis2; //  Precision Fisica
	public static int EfPrecis3; //  Posibilidad de Exico en Creacion de Items
	//Inteligencia (4)
	public static int EfInt1; //  Atk Magico
	public static int EfInt2; //  Velocidad Atk(Magico)
	public static int EfInt3; //  Precision Magica
	public static int EfInt4; //  Posibilidad de Critico Magico
	//Energia (5)
	public static int EfEne1; //  Defensa(Magica)
	public static int EfEne2; //  Mana
	public static int EfEne3; //  Regeneracion de Mana
	public static int EfEne4; //  Resistencia Critico Magico

	// Use this for initialization
	void Start () {}
	// Update is called once per frame
	void Update () {
		EfFuer1 = Atrib[0] * 7; // Aumenta Atk Fisico(Mele)
		EfFuer2 = Atrib[0] * 10; // Aumenta Resistencia
		EfFuer3 = Atrib[0] * 3; // Aumenta Bloqueo; (Sobre 1000)
		EfAgi1 = Atrib[1] * 4; // Aumenta Evacion; (Sobre 1000)
		EfAgi2 = Atrib[1] * 5; // Aumenta Velocidad Atk(Fisico); (Sobre 1000)
		EfAgi3 = Atrib[1] * 3; // Aumenta Parada(Fisica); (Sobre 1000)
		EfVit1 = Atrib[2] * 6; // Aumenta Defensa(Fisica)
		EfVit2 = Atrib[2] * 15; // Aumenta Vida
		EfVit3 = Atrib[2] * 4; // Aumenta Regeneracion de Vida
		EfVit4 = Atrib[2] * 2; // Aumenta Resistencia a Critico(Fisico); (Sobre 1000)
		EfPrecis1 = Atrib[3] * 4; // Aumenta Posibilidad de Critico(Fisico); (Sobre 1000)
		EfPrecis2 = Atrib[3] * 6; // Aumenta Precision(Fisica); (Sobre 1000)
		EfPrecis3 = Atrib[3] * 5; // Aumenta Posibilidad en Creacion de Items; (Sobre 1000)
		EfInt1 = Atrib[4] * 7; // Aumenta Atk Magico
		EfInt2 = Atrib[4] * 5; // Aumenta Velocidad Atk(Magico); (Sobre 1000)
		EfInt3 = Atrib[4] * 6; // Aumenta Precision(Magica); (Sobre 1000)
		EfInt4 = Atrib[4] * 4; // Aumenta Posibilidad de Critico(Magico); (Sobre 1000)
		EfEne1 = Atrib[5] * 6; // Aumenta Defensa(Magica)
		EfEne2 = Atrib[5] * 12; // Aumenta Mana
		EfEne3 = Atrib[5] * 3; // Aumenta Regeneracion de Mana
		EfEne4 = Atrib[5] * 2; // Aumenta Resistencia a Critico(Magico); (Sobre 1000)

		DistPuntAtrib ();
	}

	public static int DistPuntAtrib(){
		int DPAt = 0; // Total de Puntos a Distribuir
		bool[] RngCon = new bool[11]{true,false,false,false,false,false,false,false,false,false,false}; // Puntos del Rango ya obtenidos
		int IndH; // Index de Habilidad
		int IndRgC = 0; // Index de Rango

		for(IndH = 0; IndH < Habilidades.Hab.Length; IndH++){
			int RHab = Habilidades.Hab[IndH];

			if ((RHab >= 144) && (RHab <= 286)){IndRgC = 1;}
			else if ((RHab >= 287) && (RHab <= 429)){IndRgC = 2;}
			else if ((RHab >= 430) && (RHab <= 572)){IndRgC = 3;}
			else if ((RHab >= 573) && (RHab <= 715)){IndRgC = 4;}
			else if ((RHab >= 716) && (RHab <= 858)){IndRgC = 5;}
			else if ((RHab >= 859) && (RHab <= 1000)){IndRgC = 6;}
			else if ((IndH == 28) && (RHab == 1000)){IndRgC = 7;}
			else if ((IndH == 29) && (RHab == 1000)){IndRgC = 8;}
			else if ((IndH == 30) && (RHab == 1000)){IndRgC = 9;}
			else if ((IndH == 31) && (RHab == 1000)){IndRgC = 10;}

			if(RngCon[IndRgC] == false){
				if(IndRgC == 1){DPAt += 1; RngCon [IndRgC] = true;}
				else if (IndRgC == 2){DPAt += 2; RngCon [IndRgC] = true;}
				else if (IndRgC == 3){DPAt += 3; RngCon [IndRgC] = true;}
				else if (IndRgC == 4){DPAt += 4; RngCon [IndRgC] = true;}
				else if (IndRgC == 5){DPAt += 4; RngCon [IndRgC] = true;}
				else if (IndRgC == 6){DPAt += 5; RngCon [IndRgC] = true;}
				else if ((IndRgC == 7)||(IndRgC == 8)||(IndRgC == 9)||(IndRgC == 10)){DPAt += 2; RngCon[IndRgC] = true;}
			} // Agrega puntos dependiendo del Rango
		}//Fin For
		return DPAt;
	}
}
