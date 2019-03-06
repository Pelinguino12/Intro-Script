using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Array : MonoBehaviour {

	private string[] letras = new string[5] {"A","B","C","D","E"};
	int[] numeros = new int[6];
	// Use this for initialization
	void Start () {
		numeros[1] = 70;
		Debug.Log(letras[0]);
		Debug.Log(letras[1]);
		Debug.Log(letras[2]);
		Debug.Log(letras[3]);
		Debug.Log(letras[4]);
		Debug.Log(numeros[1]);
		Debug.Log(numeros[0]);
	}
}
