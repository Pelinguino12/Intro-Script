using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SumasYRestas : MonoBehaviour {

	public string nombre = "Miguel";
	public string saludo = "¿Qué tal estás?";
	public int a = 10;
	public int b = 20;
	public int suma;
	public int resta;
	public int division;
	
	// Use this for initialization
	void Start () {
		int suma = a + b;
		int resta = b - a;
		int division = b / a;
		int multiplicacion = a * b;
		int resto = b % a;
		Debug.Log(nombre + " " + saludo);
		Debug.Log("SUMA: " + suma);
		Debug.Log("RESTA: " + resta);
		Debug.Log("MULTIPLICACIÓN: " + multiplicacion);
		Debug.Log("DIVISIÓN: " + division + " RESTO: " + resto);
		Debug.Log("SUMA 1: " + ++a);
		Debug.Log("RESTA 1: " + --b);
	}
}
