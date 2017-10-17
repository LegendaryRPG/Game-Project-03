using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrucItem : MonoBehaviour {

	struct EfecBasIT{
		int AtkF;
		int AtkM;
		int DefF;
		int DefM;
		int CritF;
		int ResCritF;
		int CritM;
		int ResCritM;
		int PrecF;
		int PrecM;
		int Evac;
		int Bloqueo;
		int Parada;
		int HP;
		int MP;
		int VelF;
		int VelM;
		int ResEleAg;
		int ResEleAi;
		int ResEleFu;
		int ResEleTi;
		int ResEleLu;
		int ResEleOs;
	}

	struct ItemIT{
		int IdIT;
		string NameIT;
		string DescIT;
		int ValueIT;
		int RarIT;
		string[] CatIT;
		EfecBasIT EfecIT;
		Sprite IconIT;
		GameObject ModelIT;
	}

	enum ItemCategorys{
		AnilloR,
		AnilloL,
		Collar,
		Joyeria,
		Arma1,
		Arma2,
		Arma12,
		Daga,
		Espada,
		Hacha,
		Mandoble,
		Martillo,
		Lanza,
		Arco,
		Flecha,
		Cuchillo,
		Escudo,
		Ligera,
		Pesada,
		ArTela,
		ArCuero,
		ArPlaca,
		ArCasco,
		ArPecho,
		ArPant,
		ArGuant,
		ArBota,
		Herramienta,
		Hoz,
		PieElemental,
		PieEspiritual,
		PieEfecto,
		PieElemento,
		PieFusElemental,
		Mineral,
		Lingote,
		Ingradiente,
		Material,
		Comida,
		Pocion,
		Pergamino,
		Libro,
		Grimario
		}

	// Use this for initialization
	void Start () {}
	// Update is called once per frame
	void Update () {}
}
