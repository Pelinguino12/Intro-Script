using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuncionConDatos : MonoBehaviour {
	int edad = 20;
	// Use this for initialization
	void Start ()
	{
		Saludo();
	}
	void Saludo ()
	{
		Debug.Log("Hola, buenas tardes");
		Nombre();
		DecirEdad(edad);
		Debug.Log(DimeEdad());
	}
	void Nombre ()
	{
		Debug.Log("Miguel");
	}
	void DecirEdad (int e)
	{
		Debug.Log(e);
	}
	int DimeEdad()
	{
		return (edad);
	}
}
