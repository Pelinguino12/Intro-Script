using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enumerados : MonoBehaviour {
	public enum Brujula{Norte,Sur,Este,Oeste}
	Brujula miDireccion = Brujula.Norte;
	// Use this for initialization
	void Start ()
	{
		Debug.Log("Mi dirección es: " + miDireccion);
		CambiaDireccion(miDireccion);
	}
	Brujula CambiaDireccion (Brujula dir)
	{
		if (dir == Brujula.Norte)
		{
			dir = Brujula.Sur;
		}
		return dir;
	}
}
