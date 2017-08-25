// Creada por Ezequiel Merino, By Legendary Rpg en Unity 5.6.1 @2017
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Habilidades : MonoBehaviour {
	public static int[] Hab = new int[32]{1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1};
	public static int[] ExpTA = new int[28]; //Experiencia Total Acumulada
	int IndHab = 0; // Indice de Habilidad que se aplica experiencia (0-27)

	// Use this for initialization
	void Start () {}
	// Update is called once per frame
	void Update () {
		CalExp ();
		CamHab ();
	}

	void CamHab(){ // Puntos Maximos por habilidad 1000
		Hab [28] = ((Hab [1] + Hab [2] + Hab [3] + Hab [4]) / 4);
		Hab [29] = ((Hab [10] + Hab [11] + Hab [12]) / 3);
		Hab [30] = ((Hab [13] + Hab [14] + Hab [15]) / 3);
		Hab [31] = ((Hab [21] + Hab [22] + Hab [23] + Hab [24] + Hab [25]) / 5);
		/* Encantamiento = Hab[0];
		H_Costura = Hab[1];
		H_Armas = Hab[2];
		H_ArmadurasM = Hab[3];
		H_Artesanias = Hab[4];
		Herreria = (H_Costura + H_Armas + H_ArmadurasM + H_Artesanias) / 4 = Hab[28];
		Pesca = Hab[5];
		Cocina = Hab[6];
		Alquimia = Hab[7];
		Discrecion = Hab[8];
		Deteccion = Hab[9];
		UM_Espada = Hab[10];
		UM_Daga = Hab[11];
		UM_Hacha = Hab[12];
		ArmaUnaMano = (UM_Espada + UM_Daga + UM_Hacha) / 3 = Hab[29];
		DM_Mandoble = Hab[13];
		DM_Martillo = Hab[14];
		DM_Lanza = Hab[15];
		ArmaDosManos = (DM_Mandoble + DM_Martillo + DM_Lanza) / 3 = Hab[30];
		CuerpoaCuerpo = Hab[16];
		ArmLigera = Hab[17];
		ArmPesada = Hab[18];
		Escudo = Hab[19];
		Arco = Hab[20];
		M_Destruccion = Hab[21];
		M_Alteracion = Hab[22];
		M_Conjuracion = Hab[23];
		M_Ilucion = Hab[24];
		M_Restauracion = Hab[25];
		Magia = (M_Destruccion + M_Alteracion + M_Conjuracion + M_Ilucion + M_Restauracion) / 5 = Hab[31];
		Comercio = Hab[26];
		Escriba = Hab[27];*/
	}
	void CalExp(){
		int ExpTAS = 1000000; // Experiencia Total Acumulada en Rango S
		//int ExpMaxS = 290000; // Experiencia Maxima del Rango S
		int ExpTPS = 287840; // Experiencia Total para los primeros 140 puntos de habilidad de Rango S
		int ExpIndPS = 2056; // Experiencia Individual para los primeros 140 puntos de habilidad de Rango S
		int ExpIndFS = 2160; // Experiencia para el ultimo punto de habilidad de Rango S

		int ExpTAA = 710000; // Experiencia Total Acumulada en Rango A
		//int ExpMaxA = 240000; // Experiencia Maxima del Rango A
		int ExpTPA = 236600; // Experiencia Total para los primeros 140 puntos de habilidad de Rango A
		int ExpIndPA = 1690; // Experiencia Individual para los primeros 140 puntos de habilidad de Rango A
		//int ExpTFA = 3400; // Experiencia Total de los 2 ultimos puntos de habilidad de Rango 
		int ExpIndFA = 1700; // Experiencia Individual para los 2 ultimos puntos de habilidad de Rango A

		int ExpTAB = 470000; // Experiencia Total Acumulada en Rango B
		//int ExpMaxB = 190000; // Experiencia Maxima del Rango B
		int ExpTPB = 187320; // Experiencia Total para los primeros 140 puntos de habilidad de Rango B
		int ExpIndPB = 1338; // Experiencia Individual para los primeros 140 puntos de habilidad de Rango B
		//int ExpTFB = 2680; // Experiencia Total de los 2 ultimos puntos de habilidad de Rango B
		int ExpIndFB = 1340; // Experiencia Individual para los 2 ultimos puntos de habilidad de Rango B

		int ExpTAC = 280000; // Experiencia Total Acumulada en Rango C
		//int ExpMaxC = 140000; // Experiencia Maxima del Rango C
		int ExpTPC = 137900; // Experiencia Total para los primeros 140 puntos de habilidad de Rango C
		int ExpIndPC = 985; // Experiencia Individual para los primeros 140 puntos de habilidad de Rango C
		//int ExpTFC = 2100; // Experiencia Total de los 2 ultimos puntos de habilidad de Rango C
		int ExpIndFC = 1050; // Experiencia Individual para los 2 ultimos puntos de habilidad de Rango C

		int ExpTAD = 140000; // Experiencia Total Acumulada en Rango D
		//int ExpMaxD = 90000; // Experiencia Maxima del Rango D
		int ExpTPD = 88620; // Experiencia Total para los primeros 140 puntos de habilidad de Rango D
		int ExpIndPD = 633; // Experiencia Individual para los primeros 140 puntos de habilidad de Rango D
		//int ExpTFD = 1380; // Experiencia Total de los 2 ultimos puntos de habilidad de Rango D
		int ExpIndFD = 690; // Experiencia Individual para los 2 ultimos puntos de habilidad de Rango D

		int ExpTAE= 50000; // Experiencia Total Acumulada en Rango E
		//int ExpMaxE = 40000; // Experiencia Maxima del Rango E
		int ExpTPE = 39760; // Experiencia Total para los primeros 140 puntos de habilidad de Rango E
		int ExpIndPE = 284; // Experiencia Individual para los primeros 140 puntos de habilidad de Rango E
		//int ExpTFE = 240; // Experiencia Total de los 2 ultimos puntos de habilidad de Rango E
		int ExpIndFE = 120; // Experiencia Individual para los 2 ultimos puntos de habilidad de Rango E

		int ExpTAF = 10000; // Experiencia Total Acumulada en Rango F
		//int ExpMaxF = 10000; // Experiencia Maxima del Rango F
		int ExpTPF = 9800; // Experiencia Total de los primeros 140 puntos de habilidad de Rango F
		int ExpIndPF = 70; // Experiencia Individual para los primeros 140 puntos de habilidad de Rango F
		//int ExpTFF = 200; // Experiencia Total de los 2 ultimos puntos de habilidad de Rango F
		int ExpIndFF = 100; // Experiencia Individual para los 2 ultimos puntos de habilidad de Rango F

		for(IndHab = 0; IndHab < ExpTA.Length; IndHab++){
		 if ((ExpTA [IndHab] <= ExpTAF) && (ExpTA [IndHab] > ExpIndPF)) {
				if (ExpTA [IndHab] <= ExpTPF) {Hab [IndHab] = (ExpTA [IndHab] / ExpIndPF);} 
				else {Hab [IndHab] = ((ExpTA [IndHab] / ExpIndPF) + ((ExpTA [IndHab] - ExpTPF) / ExpIndFF));}
			} //Rango 0-10000
		 else if ((ExpTA [IndHab] <= ExpTAE) && (ExpTA [IndHab] > ExpTAF)) {
				if (ExpTA [IndHab] <= ExpTPE) {
					Hab [IndHab] = (ExpTA [IndHab] / ExpIndPE);
				} else {
					Hab [IndHab] = ((ExpTA [IndHab] / ExpIndPE) + ((ExpTA [IndHab] - ExpTPE) / ExpIndFE));
				}
			} //Rango 10001-50000
		 else if ((ExpTA [IndHab] <= ExpTAD) && (ExpTA [IndHab] > ExpTAE)) {
				if (ExpTA [IndHab] <= ExpTPD) {
					Hab [IndHab] = (ExpTA [IndHab] / ExpIndPD);
				} else {
					Hab [IndHab] = ((ExpTA [IndHab] / ExpIndPD) + ((ExpTA [IndHab] - ExpTPD) / ExpIndFD));
				}
			} //Rango 50001-140000
		 else if ((ExpTA [IndHab] <= ExpTAC) && (ExpTA [IndHab] > ExpTAD)) {
				if (ExpTA [IndHab] <= ExpTPC) {
					Hab [IndHab] = (ExpTA [IndHab] / ExpIndPC);
				} else {
					Hab [IndHab] = ((ExpTA [IndHab] / ExpIndPC) + ((ExpTA [IndHab] - ExpTPC) / ExpIndFC));
				}
			} //Rango 140001-280000
		 else if ((ExpTA [IndHab] <= ExpTAB) && (ExpTA [IndHab] > ExpTAC)) {
				if (ExpTA [IndHab] <= ExpTPB) {
					Hab [IndHab] = (ExpTA [IndHab] / ExpIndPB);
				} else {
					Hab [IndHab] = ((ExpTA [IndHab] / ExpIndPB) + ((ExpTA [IndHab] - ExpTPB) / ExpIndFB));
				}
			} //Rango 280001-470000
		 else if ((ExpTA [IndHab] <= ExpTAA) && (ExpTA [IndHab] > ExpTAB)) {
				if (ExpTA [IndHab] <= ExpTPA) {
					Hab [IndHab] = (ExpTA [IndHab] / ExpIndPA);
				} else {
					Hab [IndHab] = ((ExpTA [IndHab] / ExpIndPA) + ((ExpTA [IndHab] - ExpTPA) / ExpIndFA));
				}
			} //Rango 470001-710000
		 else if ((ExpTA [IndHab] <= ExpTAS) && (ExpTA [IndHab] > ExpTAA)) {
				if (ExpTA [IndHab] <= ExpTPS) {Hab [IndHab] = (ExpTA [IndHab] / ExpIndPS);}
				else {Hab [IndHab] = ((ExpTA [IndHab] / ExpIndPS) + ((ExpTA [IndHab] - ExpTPS) / ExpIndFS));}
			} //Rango 710001-1000000
		}//Fin For

		/* Puntos dentro de cada Rango
		* Rango S (859-999), (1000). 5
		* Rango A (716-856), (857-858). 4
		* Rango B (573-713), (714-715). 4
		* Rango C (430-570), (571-572). 3
		* Rango D (287-427), (428-429). 2
		* Rango E (144-284), (285-286). 1
		* Rango F (1-141), (142-143). */
	}

}
