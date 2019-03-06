using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Funciones : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
		Saludo();
	}
	void Saludo ()
	{
		Debug.Log("Hola, buenas tardes");
		Nombre();
	}
	void Nombre ()
	{
		Debug.Log("Miguel");
	}
}
