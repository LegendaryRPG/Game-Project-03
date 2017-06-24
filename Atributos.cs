// Creada por Ezequiel Merino, By Legendary Rpg en Unity 5.6.1 @2017
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atributos : MonoBehaviour {
	public static int[] Atrib = new int[6]{5,5,5,5,5,5};
	int EfFuer1; // Aumenta Atk Fisico(Mele)
	int EfFuer2; // Aumenta Resistencia
	int EfAgi1; // Aumenta Evacion
	double EfAgi2; // Aumenta Velocidad Atk(Fisico)
	int EfInt1; // Aumenta Atk Magico
	double EfInt2; // Aumenta Velocidad Atk(Magico)
	double EfSuer1; // Aumenta Posibilidad de Critico(Fisico/Magico)
	double EfSuer2; // Aumenta Posibilidad de Recompensa
	double EfSuer3; // Aumenta Posibilidad de Exico en Creacion de Items
	int EfEne1; // Aumenta Defensa(Magica)
	int EfEne2; // Aumenta Mana
	int EfVit1; // Aumenta Defensa(Fisica)
	int EfVit2; // Aumenta Vida

	// Use this for initialization
	void Start () {}
	// Update is called once per frame
	void Update () {
		EfFuer1 = Atrib[0] * 2; // Aumenta Atk Fisico(Mele)
		EfFuer2 = Atrib[0] * 10; // Aumenta Resistencia
		EfAgi1 = Atrib[1] * 4; // Aumenta Evacion
		EfAgi2 = Atrib[1] * 0.5; // Aumenta Velocidad Atk(Fisico)
		EfInt1 = Atrib[2] * 2; // Aumenta Atk Magico
		EfInt2 = Atrib[2] * 0.5; // Aumenta Velocidad Atk(Magico)
		EfSuer1 = Atrib[3] * 0.4; // Aumenta Posibilidad de Critico(Fisico/Magico)
		EfSuer2 = Atrib[3] * 0.3; // Aumenta Posibilidad de Recompensa
		EfSuer3 = Atrib[3] * 0.5; // Aumenta Posibilidad en Creacion de Items
		EfEne1 = Atrib[4] * 2; // Aumenta Defensa(Magica)
		EfEne2 = Atrib[4] * 12; // Aumenta Mana
		EfVit1 = Atrib[5] * 2; // Aumenta Defensa(Fisica)
		EfVit2 = Atrib[5] * 15; // Aumenta Vida
		DistPuntAtrib ();
	}
	//void CamAtrib (int IndAt,int NVAt,bool Escrip) { // Puntos maximos por atributo 100
	//	if(Escrip == true){Atrib [IndAt] = NVAt;}
		/*Fuerza = Atrib[0];
		Agilidad = Atrib[1];
		Inteligencia = Atrib[2];
		Suerte = Atrib[3];
		Energia = Atrib[4];
		Vitalidad = Atrib[5];*/
	//}
	void EfAtrib(){
		int AtFuer = Atrib[0];
		int AtAgi = Atrib[1];
		int AtInt = Atrib[2];
		int AtSuer = Atrib[3];
		int AtEne = Atrib[4];
		int AtVit = Atrib[5];
	}
	public static int DistPuntAtrib(){
		int DPAt = 0; // Total de Puntos a Distribuir
		bool[] RngCon = new bool[11]{true,false,false,false,false,false,false,false,false,false,false}; // Puntos del Rango ya obtenidos
		int IndH = 0; // Index de Habilidad
		int IndRgC = 0; // Index de Rango
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
		return DPAt;
	}
}
