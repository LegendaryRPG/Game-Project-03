// Creada por Ezequiel Merino, By Legendary Rpg en Unity 5.6.1 @2017
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DataCenter : MonoBehaviour {

	int IndHab; //Indice de Habilidad. (0-31)
	int IndAtr; //Indice de Atributo. (0-5)
	int IndHabExp; //Indice de Experiencia de Habilidad. (0-27)
	int PuntAtrb; // Puntos para agregar a los atributos.
	//int[] ComHab = new int[32]; // Comprueba cambio de Habilidad.
	//Valores de Atributos
	/*public Text Atrib_Fuer_Value = Atributos.Atrib[0].ToString();
	public Text Atrib_Agi_Value = Atributos.Atrib[1].ToString();
	public Text Atrib_Int_Value = Atributos.Atrib[2].ToString();
	public Text Atrib_Suer_Value  = Atributos.Atrib[3].ToString();
	public Text Atrib_Ene_Value = Atributos.Atrib[4].ToString();
	public Text Atrib_Vit_Value = Atributos.Atrib[5].ToString();*/
	//UI 
	/*public Image Barra_Salud;
	public Image Barra_Resis;
	public Image Barra_Mana;
	public Text Salud_Value = Atributos.EfVit2.ToString();
	public Text Resis_Value = Atributos.EfFuer2.ToString();
	public Text Mana_Value = Atributos.EfEne2.ToString();*/
	//Valores De Ataque
	/*public Text Vel_Atk_F = Atributos.EfAgi2.ToString();
	public Text Atk_F = Atributos.EfFuer1.ToString();
	public Text Pres_F;
	public Text Crit_F;
	public Text Vel_Lanz_M = Atributos.EfInt2.ToString();
	public Text Pot_M = Atributos.EfInt1.ToString();
	public Text Pres_M;
	public Text Crit_M;*/
	//Valores de Defensa
	/*public Text Def_F = Atributos.EfVit1.ToString();
	public Text Bloq_F;
	public Text Par_F;
	public Text Evas_F = Atributos.EfAgi2.ToString();
	public Text Res_Crit_F;
	public Text Def_M = Atributos.EfEne1.ToString();
	public Text Res_Crit_M;
	public Text Res_Agua;
	public Text Res_Aire;
	public Text Res_Fuego;
	public Text Res_Hielo;
	public Text Res_Relampago;
	public Text Res_Tierra;
	public Text Res_Luz;
	public Text Res_Oscuridad;*/

	//void actualizar_Ui(){}

	// Use this for initialization
	void Start () {}
	// Update is called once per frame
	void Update () {
		PuntAtrb += Atributos.DistPuntAtrib ();
		//if(ComHab[IndHab] < Habilidades.Hab[IndHab]){ComHab [IndHab] = Habilidades.Hab [IndHab];}
		//actualizar_Ui();
	}

}
